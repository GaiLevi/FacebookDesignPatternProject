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
            if(m_ViewModel.LoginButtonClicked() == true)
            {
                afterLoginInit();
            }
        }

        private void afterLoginInit()
        {
            BindingSource postsBS = new BindingSource();

            buttonLogin.Text = m_ViewModel.FacebookUser.m_UserName;
            //buttonLogin.DataBindings.Add("Text", bs, "FacebookUser.m_UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            //pictureBoxProfile.DataBindings.Add("ImageLocation", bs, "LoginService.m_LoggedInUser.PictureNormalURL", true, DataSourceUpdateMode.OnPropertyChanged);
            pictureBoxProfile.ImageLocation = m_ViewModel.FacebookUser.m_PictureURL;

            iPostBindingSource.DataSource = m_ViewModel.FacebookUser.m_PostCollection;
            //listBoxComments.DataSource = iPostBindingSource.DataMember;
            //postsBS = m_ViewModel.bsPosts;
            //labelID.DataBindings.Add("Text", postsBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            //listBoxPosts.DataSource = postsBS;
            //listBoxPosts.DisplayMember = "Message";
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
			//FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
            m_ViewModel.LogoutButtonClicked();
        }

    }
}
