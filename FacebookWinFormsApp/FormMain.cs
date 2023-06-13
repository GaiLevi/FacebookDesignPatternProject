using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Contracts;
using FacebookViewModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly ViewModel r_ViewModel;
        private bool m_IsLoggedIn { get; set; }
        private BindingSource m_BindingSource;
        public PictureBoxCollection m_PictureBoxCollection { get; set; }
        private readonly object r_PostLock = new object();
        private readonly object r_GroupLock = new object();
        private readonly object r_EventLock = new object();
        private readonly object r_PageLock = new object();
        private readonly object r_AlbumLock = new object();
        private readonly object r_PicturesLock = new object();
        private const string k_DummyTextForPostTextBox = "What's on your mind?";
        private FormEditPicture m_FormEditPicture;


        public FormMain()
        {
            r_ViewModel = new ViewModel();
            initForm();
        }

        private void initForm()
        {
            InitializeComponent();
            m_IsLoggedIn = false;
            initPictureBoxCollectionForAlbumTab();
            m_BindingSource = new BindingSource { DataSource = r_ViewModel };
            r_ViewModel.PropertyChanged += OnViewModel_PropertyChanged;
            PictureBoxPost.DataBindings.Add("ImageLocation", iPostBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxGroup.DataBindings.Add("ImageLocation", iGroupBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxEvent.DataBindings.Add("ImageLocation", iEventBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxPage.DataBindings.Add("ImageLocation", iPageBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            r_ViewModel.NewPostAdded += OnViewModel_NewPostAdded;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            r_ViewModel.m_AppStarTime = DateTime.Now;
            this.checkBoxAutoLogin.Checked = ApplicationSettings.Instance.m_AutoLogin;
            if(ApplicationSettings.Instance.m_AutoLogin)
            {
                new Thread(() => r_ViewModel.AutoLogin(ApplicationSettings.Instance.m_AccessToken)).Start();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.m_AutoLogin = this.checkBoxAutoLogin.Checked;
            ApplicationSettings.Instance.Save();
            r_ViewModel.PropertyChanged -= OnViewModel_PropertyChanged;
        }

        protected virtual void OnViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "AccessToken")
            {
                afterLoginInit();
                ApplicationSettings.Instance.m_AccessToken = r_ViewModel.AccessToken;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            OnButtonLoginClicked();
        }

        protected virtual void OnButtonLoginClicked()
        {
            Clipboard.SetText("design.patterns.22aa");
            r_ViewModel.LoginButtonClicked();
        }

        private void afterLoginInit()
        {
            buttonLogin.Invoke(new Action(() =>
                {
                    buttonLogin.Text = string.Format($@"Log in as {r_ViewModel.FacebookUser.m_UserName}");
                    buttonLogin.Enabled = false;
                }));
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.ImageLocation = r_ViewModel.FacebookUser.m_PictureURL));
            labelWelcomeToApp.Invoke(new Action(() => labelWelcomeToApp.Visible = false));
            textBoxPost.Invoke(new Action(() => textBoxPost.Visible = true));
            buttonWritePost.Invoke(new Action(() => buttonWritePost.Visible = true));
            tabControlFeatures.Invoke(new Action(() => tabControlFeatures.Visible = true));
            m_IsLoggedIn = true;
            initPostTab();
        }

        private void initPictureBoxCollectionForAlbumTab()
        {
            m_PictureBoxCollection = new PictureBoxCollection();
            TabPage tabPageAlbum = tabControlFeatures.TabPages[5];
            tabPageAlbum.Controls.Add(m_PictureBoxCollection);
            m_PictureBoxCollection.Location = new Point(399, 60);
            m_PictureBoxCollection.Size = new Size(150,150);
            m_PictureBoxCollection.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			OnButtonLogOutClicked();
        }

        protected virtual void OnButtonLogOutClicked()
        {
            r_ViewModel.LogoutButtonClicked();
            buttonLogin.Invoke(new Action(() =>
                {
                    buttonLogin.Text = string.Format(@"Login");
                    buttonLogin.Enabled = true;
                }));
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.ImageLocation = null));
            textBoxPost.Invoke(new Action(() => textBoxPost.Visible = false));
            buttonWritePost.Invoke(new Action(() => buttonWritePost.Visible = false));
            tabControlFeatures.Invoke(new Action(() => tabControlFeatures.Visible = false));
            labelWelcomeToApp.Invoke(new Action(() => labelWelcomeToApp.Visible = true));
            m_IsLoggedIn = false;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        { 
            displaySelectedPostComments();
        }

        private void displaySelectedPostComments()
        {
            bool hasSingleSelectedItem = (bool)listBoxPosts.Invoke(new Func<bool>(() => listBoxPosts.SelectedItems.Count == 1));
            if (hasSingleSelectedItem)
            {
                IPost selectedItemAsIPost = (IPost)listBoxPosts.Invoke(new Func<IPost>(() => listBoxPosts.SelectedItem as IPost));
                if (selectedItemAsIPost != null)
                {
                    try
                    {
                        selectedItemAsIPost.LoadComments();
                        listBoxComments.Invoke(new Action(() => listBoxComments.DataSource = selectedItemAsIPost.m_Comments));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbumPhotos();
        }

        private void displaySelectedAlbumPhotos()
        {
            bool hasSingleSelectedItem = (bool)listBoxAlbums.Invoke(new Func<bool>(() => listBoxAlbums.SelectedItems.Count == 1));
            if (hasSingleSelectedItem)
            {
                IAlbum selectedItemAsIAlbum = (IAlbum)listBoxAlbums.Invoke(new Func<IAlbum>(() => listBoxAlbums.SelectedItem as IAlbum));
                if (selectedItemAsIAlbum != null)
                {
                    Thread picturesThread = new Thread(new ThreadStart(() =>
                    {
                        try
                        {
                            lock (r_PicturesLock)
                            {
                                if (selectedItemAsIAlbum.m_PicturesUrl == null)
                                {
                                    selectedItemAsIAlbum.LoadAlbumPictures();
                                    labelIsAlbumLoading.Invoke(new Action(() => labelIsAlbumLoading.Visible = true));
                                }
                                BeginInvoke(new Action(() =>
                                {
                                    m_PictureBoxCollection.SetList(selectedItemAsIAlbum.m_PicturesUrl);
                                    m_PictureBoxCollection.MoveNext();
                                    labelIsAlbumLoading.Invoke(new Action(() => labelIsAlbumLoading.Visible = false));
                                }));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                    picturesThread.Start();
                }
            }
        }

        private void initPostTab()
        {
            Thread postThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock(r_PostLock)
                    {
                        if(r_ViewModel.FacebookUser.m_PostCollection == null)
                        {
                            r_ViewModel.FacebookUser.LoadCollection<IPost>();
                            BeginInvoke(
                                new Action(
                                    () =>
                                        {
                                            iPostBindingSource.DataSource = r_ViewModel.FacebookUser.m_PostCollection;
                                            displaySelectedPostComments();
                                        }));
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));

            postThread.Start();
        }

        private void initGroupTab()
        {
            Thread groupThread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        lock (r_GroupLock)
                        {
                            if (r_ViewModel.FacebookUser.m_GroupCollection == null)
                            {
                                r_ViewModel.FacebookUser.LoadCollection<IGroup>();
                                BeginInvoke(new Action(() =>
                                    {
                                        iGroupBindingSource.DataSource = r_ViewModel.FacebookUser.m_GroupCollection;
                                    }));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));

            groupThread.Start();
        }

        private void initEventTab()
        {
            Thread eventThread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        lock (r_EventLock)
                        {
                            if (r_ViewModel.FacebookUser.m_EventCollection == null)
                            {
                                r_ViewModel.FacebookUser.LoadCollection<IEvent>();
                                BeginInvoke(new Action(() =>
                                    {
                                        iEventBindingSource.DataSource = r_ViewModel.FacebookUser.m_EventCollection;
                                    }));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }));

            eventThread.Start();
        }

        private void initPageTab()
        {
            Thread pageThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock (r_PageLock)
                    {
                        if (r_ViewModel.FacebookUser.m_PageCollection == null)
                        {
                            r_ViewModel.FacebookUser.LoadCollection<IPage>();
                            BeginInvoke(new Action(() =>
                                {
                                    iPageBindingSource.DataSource = r_ViewModel.FacebookUser.m_PageCollection;
                                }));
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));

            pageThread.Start();
        }

        private void initAlbumTab()
        {
            Thread albumThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock (r_AlbumLock)
                    {
                        if (r_ViewModel.FacebookUser.m_AlbumCollection == null)
                        {
                            r_ViewModel.FacebookUser.LoadCollection<IAlbum>();
                            BeginInvoke(new Action(() =>
                                {
                                    iAlbumBindingSource.DataSource = r_ViewModel.FacebookUser.m_AlbumCollection;
                                    displaySelectedAlbumPhotos();
                                }));
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));

            albumThread.Start();
        }

        private void tabControlFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnTabControlFeaturesSelectedIndexChanged();
        }

        protected virtual void OnTabControlFeaturesSelectedIndexChanged()
        {
            if (m_IsLoggedIn)
            {
                switch (tabControlFeatures.SelectedIndex)
                {
                    case 0:
                        bool havePostItem = (bool)listBoxPosts.Invoke(new Func<bool>(() => listBoxPosts.Items.Count == 0));
                        if (havePostItem)
                        {
                            initPostTab();
                        }
                        break;
                    case 1:
                        bool haveGroupItem = (bool)listBoxGroups.Invoke(new Func<bool>(() => listBoxGroups.Items.Count == 0));
                        if (haveGroupItem)
                        {
                            initGroupTab();
                        }
                        break;
                    case 2:
                        MessageBox.Show("This is not working due to Facebook's new policy", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("This is not working due to Facebook's new policy", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //bool haveEventItem = (bool)listBoxEvents.Invoke(new Func<bool>(() => listBoxEvents.Items.Count == 0));
                        //if (haveEventItem)
                        //{
                        //    initEventTab();
                        //}
                        break;
                    case 4:
                        bool havePageItem = (bool)listBoxPages.Invoke(new Func<bool>(() => listBoxPages.Items.Count == 0));
                        if (havePageItem)
                        {
                            initPageTab();
                        }
                        break;
                    case 5:
                        bool haveAlbumItem = (bool)listBoxAlbums.Invoke(new Func<bool>(() => listBoxAlbums.Items.Count == 0));
                        if (haveAlbumItem)
                        {
                            initAlbumTab();
                        }
                        break;
                    case 6:
                        timerApp.Start();
                        break;
                }
            }
        }

        private void timerApp_Tick(object sender, EventArgs e)
        {
            OnTimerAppTicked();
        }

        protected virtual void OnTimerAppTicked()
        {
            textBoxTimeSpentInTheApp.Invoke(new Action(() => textBoxTimeSpentInTheApp.Text = r_ViewModel.SetTimersMSG()));
        }

        protected virtual void OnButtonGenerateBetterThingToDoClicked()
        {
            textBoxBetterThingToDo.Invoke(new Action(() => textBoxBetterThingToDo.Text = r_ViewModel.GetBetterThingFromDic()));
        }

        private void buttonGenerateBetterThingToDo_Click(object sender, EventArgs e)
        {
            OnButtonGenerateBetterThingToDoClicked();
        }

        private void buttonPreviousPicture_Click(object sender, EventArgs e)
        {
            OnButtonPreviousPictureClicked();
        }

        protected virtual void OnButtonPreviousPictureClicked()
        {
            if (m_IsLoggedIn)
            {
                m_PictureBoxCollection.Prev();
            }
        }

        private void buttonNextPicture_Click(object sender, EventArgs e)
        {
          OnButtonNextPictureClicked();
        }

        protected virtual void OnButtonNextPictureClicked()
        {
            if (m_IsLoggedIn)
            {
                m_PictureBoxCollection.MoveNext();
            }
        }


        private void buttonWritePost_Click(object sender, EventArgs e)
        {
            OnButtonWritePostClicked(textBoxPost.Text);
        }

        private void OnViewModel_NewPostAdded()
        {
            listBoxPosts.DataSource = null;
            listBoxPosts.DataSource = iPostBindingSource;
            listBoxPosts.DisplayMember = "m_MSG";
        }

        protected virtual void OnButtonWritePostClicked(string i_PostText)
        {
            if (textBoxPost.Text != k_DummyTextForPostTextBox && textBoxPost.Text != null)
            {
                r_ViewModel.AddNewPost(i_PostText);
                textBoxPost.Text = string.Empty;
                setTextBoxPost();
            }
            else
            {
                MessageBox.Show("You need to write something!");
            }
        }
     

        private void textBoxPost_Enter(object sender, EventArgs e)
        {
           OnTextBoxPostEntered();
        }

        protected virtual void OnTextBoxPostEntered()
        {
            if (textBoxPost.Text == k_DummyTextForPostTextBox)
            {
                textBoxPost.Text = string.Empty;
                textBoxPost.ForeColor = Color.Black;
            }
        }

        private void setTextBoxPost()
        {
            if (string.IsNullOrEmpty(textBoxPost.Text))
            {
                textBoxPost.Text = k_DummyTextForPostTextBox;
                textBoxPost.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxPost_Leave(object sender, EventArgs e)
        {
            OnTextBoxPostLeaved();
        }

        protected virtual void OnTextBoxPostLeaved()
        {
            setTextBoxPost();
        }

        private void buttonEditPicture_Click(object sender, EventArgs e)
        {
            OnButtonEditPictureClicked();
        }

        protected virtual void OnButtonEditPictureClicked()
        {
            if (m_PictureBoxCollection.Image != null)
            {
                m_FormEditPicture = new FormEditPicture(m_PictureBoxCollection.Image);
                m_FormEditPicture.FormEditPictureClosing += formEditPicture_Closing;
                m_FormEditPicture.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose an image");
            }
        }
        private void formEditPicture_Closing(object sender, FormClosingEventArgs e)
        {
            OnFormEditPictureClosing();
        }

        protected virtual void OnFormEditPictureClosing()
        {
            m_FormEditPicture.FormEditPictureClosing -= formEditPicture_Closing;
            m_FormEditPicture.Dispose();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
