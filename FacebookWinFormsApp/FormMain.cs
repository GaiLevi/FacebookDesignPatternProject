using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookViewModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        ViewModel m_ViewModel;
        BindingSource bs;
        BindingSource postsBS;
        public FormMain()
        {
            InitializeComponent();
            //FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_ViewModel = new ViewModel();
            bs = new BindingSource { DataSource = m_ViewModel };
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.22aa");
            m_ViewModel.LoginButtonClicked();

            BindingSource postsBS = new BindingSource();
            //bSource.DataSource = m_ViewModel.m_User;
            
            //postBindingSource.DataSource = m_ViewModel.GetPosts();
            //userBindingSource.DataSource = m_ViewModel.m_User;
            
            buttonLogin.DataBindings.Add("Text", bs, "LoginService.m_LoggedInUser.Name", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxProfile.DataBindings.Add("ImageLocation", bs, "LoginService.m_LoggedInUser.PictureNormalURL", true, DataSourceUpdateMode.OnPropertyChanged);

            postsBS = m_ViewModel.bsPosts;
            labelID.DataBindings.Add("Text", postsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            listBoxPosts.DataSource = postsBS;
            listBoxPosts.DisplayMember = "Message";
           
            //listBoxPosts.DataBindings.Add("Text", bs, "LoginService.m_LoggedInUser.Name", true, DataSourceUpdateMode.OnPropertyChanged);
            //       Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            //       FacebookWrapper.LoginResult loginResult = FacebookService.Login(
            //               /// (This is Desig Patter's App ID. replace it with your own)
            //               "1450160541956417", 
            //               /// requested permissions:
            //"email",
            //               "public_profile"
            //               /// add any relevant permissions
            //               );

            //       buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			//FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
            m_ViewModel.LogoutButtonClicked();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
