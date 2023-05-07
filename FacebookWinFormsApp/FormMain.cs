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
            m_ViewModel = new ViewModel();
            bs = new BindingSource { DataSource = m_ViewModel };
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.22aa");
            m_ViewModel.LoginButtonClicked();

            BindingSource postsBS = new BindingSource();

            buttonLogin.DataBindings.Add("Text", bs, "LoginService.m_LoggedInUser.Name", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxProfile.DataBindings.Add("ImageLocation", bs, "LoginService.m_LoggedInUser.PictureNormalURL", true, DataSourceUpdateMode.OnPropertyChanged);

            postsBS = m_ViewModel.bsPosts;
            labelID.DataBindings.Add("Text", postsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            listBoxPosts.DataSource = postsBS;
            listBoxPosts.DisplayMember = "Message";
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
