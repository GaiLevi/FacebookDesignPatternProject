﻿using System;
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
        ViewModel m_ViewModel;
        bool m_IsLoggedIn = false;
        BindingSource m_BindingSource;
        PictureBoxCollection m_PictureBoxCollection;
        //Locks
        private object postLock = new object();
        private object groupLock = new object();
        private object eventLock = new object();
        private object pageLock = new object();
        private object albumLock = new object();
        private Thread m_CurrentThread;
        private const string k_DummyTextForPostTextBox = "What's on your mind?";

        public FormMain()
        {
            InitializeComponent();
            initPictureBoxCollectionForAlbumTab();
            m_ViewModel = new ViewModel();
            m_BindingSource = new BindingSource { DataSource = m_ViewModel };
            m_ViewModel.PropertyChanged += OnViewModel_PropertyChanged;

            PictureBoxPost.DataBindings.Add("ImageLocation", iPostBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxGroup.DataBindings.Add("ImageLocation", iGroupBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxEvent.DataBindings.Add("ImageLocation", iEventBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxPage.DataBindings.Add("ImageLocation", iPageBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //this.Size = ApplicationSettings.Instance.LastWindowSize;
            //this.WindowState = ApplicationSettings.Instance.LastWindowState;
            //this.Location = ApplicationSettings.Instance.LastWindowLocation;
            m_ViewModel.m_AppStarTime = DateTime.Now;
            this.checkBoxAutoLogin.Checked = ApplicationSettings.Instance.AutoLogin;
            if(ApplicationSettings.Instance.AutoLogin)
            {
                new Thread(() => m_ViewModel.AutoLogin(ApplicationSettings.Instance.AccessToken)).Start();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            //ApplicationSettings.Instance.LastWindowState = this.WindowState;
            //ApplicationSettings.Instance.LastWindowSize = this.Size;
            //ApplicationSettings.Instance.LastWindowLocation = this.Location;
            ApplicationSettings.Instance.AutoLogin = this.checkBoxAutoLogin.Checked;
            ApplicationSettings.Instance.Save();
            m_ViewModel.PropertyChanged -= OnViewModel_PropertyChanged;
            
        }

        protected virtual void OnViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "AccessToken")
            {
                afterLoginInit();
                ApplicationSettings.Instance.AccessToken = m_ViewModel.AccessToken;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            OnButtonLogin_Click();
        }

        protected virtual void OnButtonLogin_Click()
        {
            Clipboard.SetText("design.patterns.22aa");
            m_ViewModel.LoginButtonClicked();
        }


        private void afterLoginInit()
        {

            //textBoxPost.Visible = true;
            //buttonPost.Visible = true;
            buttonLogin.Invoke(new Action(() =>
                {
                    buttonLogin.Text = string.Format($@"Log in as {m_ViewModel.FacebookUser.m_UserName}");
                    buttonLogin.Enabled = false;
                }));
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.ImageLocation = m_ViewModel.FacebookUser.m_PictureURL));
            labelWelcomeToApp.Invoke(new Action(() => labelWelcomeToApp.Visible = false));
            textBoxPost.Invoke(new Action(() => textBoxPost.Visible = true));
            buttonWritePost.Invoke(new Action(() => buttonWritePost.Visible = true));
            tabControlFeatures.Invoke(new Action(() => tabControlFeatures.Visible = true));
            m_IsLoggedIn = true;
            initPostTab();
            

            //iPostBindingSource.DataSource = m_ViewModel.FacebookUser.m_PostCollection;
            //PictureBoxPost.DataBindings.Add("ImageLocation", iPostBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);

            //listBoxComments.DataSource = iPostBindingSource.DataSource;
            //postsBS = m_ViewModel.bsPosts;
            //labelID.DataBindings.Add("Text", postsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //listBoxPosts.DataSource = postsBS;
            //listBoxPosts.DisplayMember = "Message";
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
			OnButtonLogOut_Click();
        }

        protected virtual void OnButtonLogOut_Click()
        {
            m_ViewModel.LogoutButtonClicked();
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
                    selectedItemAsIPost.LoadComments();
                    listBoxComments.Invoke(new Action(() => listBoxComments.DataSource = selectedItemAsIPost.m_Comments));
                }
            }
        }
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbumPhotos();
        }




        //private void displaySelectedAlbumPhotos()
        //{
        //    bool hasSingleSelectedItem = (bool)listBoxAlbums.Invoke(new Func<bool>(() => listBoxAlbums.SelectedItems.Count == 1));
        //    if (hasSingleSelectedItem)
        //    {
        //        IAlbum selectedAlbum = (IAlbum)listBoxPosts.Invoke(new Func<IPost>(() => listBoxAlbums.SelectedItem as IPost));
        //        if (selectedAlbum != null)
        //        {
        //            selectedAlbum.LoadAlbumPictures();
        //        }
        //        if (selectedAlbum != null && selectedAlbum.m_PicturesUrl.Count > 0)
        //        {
        //            m_PictureBoxCollection.SetList(selectedAlbum.m_PicturesUrl);
        //            m_PictureBoxCollection.MoveNext();
        //        }
        //        else
        //        {
        //            //m_PictureBoxCollection.SetList(selectedAlbum.m_PicturesUrl);
        //            //m_PictureBoxCollection.MoveNext();
        //        }
        //    }
        //}
        private void displaySelectedAlbumPhotos()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                if (listBoxAlbums.SelectedItem is IAlbum)
                {
                    IAlbum selectedAlbum = (IAlbum)listBoxAlbums.SelectedItem;
                    selectedAlbum.LoadAlbumPictures();
                    if (selectedAlbum.m_PicturesUrl.Count > 0)
                    {
                        m_PictureBoxCollection.SetList(selectedAlbum.m_PicturesUrl);
                        m_PictureBoxCollection.MoveNext();
                    }
                    else
                    {
                        m_PictureBoxCollection.SetList(selectedAlbum.m_PicturesUrl);
                        m_PictureBoxCollection.MoveNext();
                    }
                }
            }
        }

        private void initPostTab()
        {
            //iPostBindingSource.DataSource = m_ViewModel.FacebookUser.m_PostCollection;
            //if (m_ViewModel.FacebookUser.m_PostCollection.Count > 0)
            //{
            //    //PictureBoxPost.DataBindings.Add("ImageLocation", iPostBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            //}
            //displaySelectedPostComments();

            //m_CurrentThread?.Join();
            Thread postThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock(postLock)
                    {
                        if(m_ViewModel.FacebookUser.m_PostCollection == null)
                        {
                            m_ViewModel.FacebookUser.LoadPostsFromApi();
                            BeginInvoke(
                                new Action(
                                    () =>
                                        {
                                            iPostBindingSource.DataSource = m_ViewModel.FacebookUser.m_PostCollection;
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
            //m_ViewModel.FacebookUser.LoadGroupsFromApi();
            //iGroupBindingSource.DataSource = m_ViewModel.FacebookUser.m_GroupCollection;
            //if (m_ViewModel.FacebookUser.m_GroupCollection.Count > 0)
            //{
            //    //pictureBoxGroup.DataBindings.Add("ImageLocation", iGroupBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            //}

            //m_CurrentThread?.Join();
            Thread groupThread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        lock (groupLock)
                        {
                            if (m_ViewModel.FacebookUser.m_GroupCollection == null)
                            {
                                m_ViewModel.FacebookUser.LoadGroupsFromApi();
                                BeginInvoke(new Action(() =>
                                    {
                                        iGroupBindingSource.DataSource = m_ViewModel.FacebookUser.m_GroupCollection;
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
            //m_ViewModel.FacebookUser.LoadEventsFromApi();
            //iEventBindingSource.DataSource = m_ViewModel.FacebookUser.m_EventCollection;
            //if (m_ViewModel.FacebookUser.m_EventCollection.Count > 0)
            //{
            //    //pictureBoxEvent.DataBindings.Add("ImageLocation", iEventBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            //}        

            //m_CurrentThread?.Join();
            Thread eventThread = new Thread(new ThreadStart(() =>
                {
                    try
                    {
                        lock (eventLock)
                        {
                            if (m_ViewModel.FacebookUser.m_EventCollection == null)
                            {
                                m_ViewModel.FacebookUser.LoadEventsFromApi();
                                BeginInvoke(new Action(() =>
                                    {
                                        iEventBindingSource.DataSource = m_ViewModel.FacebookUser.m_EventCollection;
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
            //no thread
            //m_ViewModel.FacebookUser.LoadPagesFromApi();
            //iPageBindingSource.DataSource = m_ViewModel.FacebookUser.m_PageCollection;

            //if (m_ViewModel.FacebookUser.m_PageCollection.Count > 0)
            //{
            //    //pictureBoxPage.DataBindings.Add("ImageLocation", iPageBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            //}

            //first thread try
            //m_CurrentThread?.Join();
            Thread pageThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock (pageLock)
                    {
                        if (m_ViewModel.FacebookUser.m_PageCollection == null)
                        {
                            m_ViewModel.FacebookUser.LoadPagesFromApi();
                            BeginInvoke(new Action(() =>
                                {
                                    iPageBindingSource.DataSource = m_ViewModel.FacebookUser.m_PageCollection;
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
            //m_ViewModel.FacebookUser.LoadAlbumsFromApi();
            //iAlbumBindingSource.DataSource = m_ViewModel.FacebookUser.m_AlbumCollection;
            //displaySelectedAlbumPhotos();
            //if (m_ViewModel.FacebookUser.m_AlbumCollection.Count > 0)
            //{
            //    //pictureBoxAlbum.DataBindings.Add("ImageLocation", iAlbumBindingSource, "m_PicturesUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            //}

            //m_CurrentThread?.Join();
            Thread albumThread = new Thread(new ThreadStart(() =>
            {
                try
                {
                    lock (albumLock)
                    {
                        if (m_ViewModel.FacebookUser.m_AlbumCollection == null)
                        {
                            m_ViewModel.FacebookUser.LoadAlbumsFromApi();
                            BeginInvoke(new Action(() =>
                                {
                                    iAlbumBindingSource.DataSource = m_ViewModel.FacebookUser.m_AlbumCollection;
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
            if (m_IsLoggedIn)
            {
                //timerApp.Stop();
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
                        bool haveEventItem = (bool)listBoxEvents.Invoke(new Func<bool>(() => listBoxEvents.Items.Count == 0));
                        if (haveEventItem)
                        {
                            initEventTab();
                        }
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
            OnTimerAppTick();
        }

        protected virtual void OnTimerAppTick()
        {
            textBoxTimeSpentInTheApp.Invoke(new Action(() => textBoxTimeSpentInTheApp.Text = m_ViewModel.SetTimersMSG()));
        }


        protected virtual void OnButtonGenerateBetterThingToDoClicked()
        {
            textBoxBetterThingToDo.Invoke(new Action(() => textBoxBetterThingToDo.Text = m_ViewModel.GetBetterThingFromDic()));
        }
        private void buttonGenerateBetterThingToDo_Click(object sender, EventArgs e)
        {
            OnButtonGenerateBetterThingToDoClicked();
        }
        private void buttonEditPicture_Click(object sender, EventArgs e)
        {

        }

        private void buttonPreviousPicture_Click(object sender, EventArgs e)
        {
            if(m_IsLoggedIn)
            {
                m_PictureBoxCollection.Prev();
            }
        }

        private void buttonNextPicture_Click(object sender, EventArgs e)
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

        //TODO: need to add post to Posts!!!!!!!!!!!!!!!!!!!!!!!
        protected virtual void OnButtonWritePostClicked(string i_PostText)
        {
            if (textBoxPost.Text != k_DummyTextForPostTextBox && textBoxPost.Text != null)
            {
                //if (ButtonPostClicked != null)
                //{
                    //ButtonPostClicked.Invoke(i_PostText);
                    textBoxPost.Text = string.Empty;
                    setTextBoxPost();
                //}
            }
            else
            {
                MessageBox.Show("You need to write somthing!");
            }
        }

        private void textBoxPost_Enter(object sender, EventArgs e)
        {
           OnTextBoxPost_Enter();
        }

        protected virtual void OnTextBoxPost_Enter()
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
            OnTextBoxPost_Leave();
        }

        protected virtual void OnTextBoxPost_Leave()
        {
            setTextBoxPost();
        }


        //public void InsertNewPostToListBoxPosts(string i_Id, string i_Text)
        //{
        //    if (listBoxPosts.DataSource is List<KeyValuePair<string, string>>)
        //    {
        //        List<KeyValuePair<string, string>> dataSource = (List<KeyValuePair<string, string>>)listBoxPosts.DataSource;
        //        KeyValuePair<string, string> postToAdd = new KeyValuePair<string, string>(i_Id, i_Text);
        //        dataSource.Insert(0, postToAdd);
        //        listBoxPosts.DataSource = null;
        //        listBoxPosts.DisplayMember = "Value";
        //        listBoxPosts.DataSource = dataSource;
        //    }
        //}
    }
}
