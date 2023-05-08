using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Contracts;
using FacebookViewModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        ViewModel m_ViewModel;
        bool isLoggedIn = false;
        BindingSource bs;
        public FormMain()
        {
            InitializeComponent();
            m_ViewModel = new ViewModel();
            bs = new BindingSource { DataSource = m_ViewModel };
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.22aa");
            isLoggedIn = m_ViewModel.LoginButtonClicked();
            if (isLoggedIn == true)
            {
                afterLoginInit();
            }
        }

        private void afterLoginInit()
        {
            buttonLogin.Text = m_ViewModel.FacebookUser.m_UserName;
            pictureBoxProfile.ImageLocation = m_ViewModel.FacebookUser.m_PictureURL;
            initPostTab();

            //iPostBindingSource.DataSource = m_ViewModel.FacebookUser.m_PostCollection;
            //PictureBoxPost.DataBindings.Add("ImageLocation", iPostBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);

            //listBoxComments.DataSource = iPostBindingSource.DataSource;
            //postsBS = m_ViewModel.bsPosts;
            //labelID.DataBindings.Add("Text", postsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //listBoxPosts.DataSource = postsBS;
            //listBoxPosts.DisplayMember = "Message";
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
			buttonLogin.Text = "Login";
            m_ViewModel.LogoutButtonClicked();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPostComments();
        }

        private void displaySelectedPostComments()
        {
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                if (listBoxPosts.SelectedItem is IPost)
                {
                    IPost selectedPost = (IPost)listBoxPosts.SelectedItem;
                    selectedPost.LoadComments();
                    listBoxComments.DataSource = selectedPost.m_Comments;
                }
            }
        }
        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbumPhotos();
        }

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
                        pictureBoxAlbum.ImageLocation = selectedAlbum.m_PicturesUrl.First();
                        //pictureBoxAlbum.DataBindings.Add("ImageLocation", iAlbumBindingSource, "m_PicturesUrl.First()", true, DataSourceUpdateMode.OnPropertyChanged);
                    }
                }
            }
        }

        private void initPostTab()
        {
            iPostBindingSource.DataSource = m_ViewModel.FacebookUser.m_PostCollection;
            if (m_ViewModel.FacebookUser.m_PostCollection.Count > 0)
            {
                PictureBoxPost.DataBindings.Add("ImageLocation", iPostBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            displaySelectedPostComments();
        }

        private void initGroupTab()
        {
            m_ViewModel.FacebookUser.LoadGroupsFromApi();
            iGroupBindingSource.DataSource = m_ViewModel.FacebookUser.m_GroupCollection;
            if (m_ViewModel.FacebookUser.m_GroupCollection.Count > 0)
            {
                pictureBoxGroup.DataBindings.Add("ImageLocation", iGroupBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void initEventTab()
        {
            m_ViewModel.FacebookUser.LoadEventsFromApi();
            iEventBindingSource.DataSource = m_ViewModel.FacebookUser.m_EventCollection;
            if (m_ViewModel.FacebookUser.m_EventCollection.Count > 0)
            {
                pictureBoxEvent.DataBindings.Add("ImageLocation", iEventBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            }        
        }

        private void initPageTab()
        {
            m_ViewModel.FacebookUser.LoadPagesFromApi();
            iPageBindingSource.DataSource = m_ViewModel.FacebookUser.m_PageCollection;
            if (m_ViewModel.FacebookUser.m_PageCollection.Count > 0)
            {
                pictureBoxPage.DataBindings.Add("ImageLocation", iPageBindingSource, "m_PictureUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void initAlbumTab()
        {
            m_ViewModel.FacebookUser.LoadAlbumsFromApi();
            iAlbumBindingSource.DataSource = m_ViewModel.FacebookUser.m_AlbumCollection;
            displaySelectedAlbumPhotos();
            if (m_ViewModel.FacebookUser.m_AlbumCollection.Count > 0)
            {
                //pictureBoxAlbum.DataBindings.Add("ImageLocation", iAlbumBindingSource, "m_PicturesUrl", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void tabControlFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                //timerApp.Stop();
                switch (tabControlFeatures.SelectedIndex)
                {
                    case 0:
                        if (listBoxPosts.Items.Count == 0)
                        {
                            initPostTab();
                        }
                        break;
                    case 1:
                        if (listBoxGroups.Items.Count == 0)
                        {
                            initGroupTab();
                        }
                        break;
                    //case 2:
                    //    fetchFriends();
                    //    break;
                    case 3:
                        if (listBoxEvents.Items.Count == 0)
                        {
                            initEventTab();
                        }
                        break;
                    case 4:
                        if (listBoxPages.Items.Count == 0)
                        {
                            initPageTab();
                        }
                        break;
                    case 5:
                        if (listBoxAlbums.Items.Count == 0)
                        {
                            initAlbumTab();
                        }
                        break;
                        //case 6:
                        //    timerApp.Start();
                        //    break;
                }
            }
        }

        private void buttonEditPicture_Click(object sender, EventArgs e)
        {

        }

        private void buttonPreviousPicture_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
