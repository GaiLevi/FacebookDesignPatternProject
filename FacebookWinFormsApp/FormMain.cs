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
        public FormMain()
        {
            InitializeComponent();
            //FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_ViewModel = new ViewModel();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.22aa");
            m_ViewModel.LoginButtonClicked();

            BindingSource bSource = new BindingSource();
            //bSource.DataSource = m_ViewModel.m_User;
            
            postBindingSource.DataSource = m_ViewModel.GetPosts();
            userBindingSource.DataSource = m_ViewModel.m_User;
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
