using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookModel
{
    public class LoginService
    {
        public User m_LoggedInUser { get; set; }
        public LoginResult m_LoginResult { get; set; }

        public UserData m_UserData { get; set; }

        private LoginService()
        {
            loginAndInit();
        }

        public static LoginService Instance
        {
            get { return Singleton<LoginService>.Instance;}
        }

        public void loginAndInit()
        {
            FacebookService.s_CollectionLimit = 100;
            try
            {
                m_LoginResult = FacebookService.Login(
                    "1450160541956417",
                    //"901251131122072",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");


                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    //r_FormMain.InitAppAfterLogin();
                    //r_FormMain.SetButtonLoginText(m_LoggedInUser.Name);
                    //r_FormMain.SetProfilePictureBox(m_LoggedInUser.PictureNormalURL);
                    //setUserBirthDay();

                    //m_UserData = new UserData(m_LoggedInUser);
                }
                else
                {
                    //MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void LogoutAndSet()
        {
            FacebookService.LogoutWithUI();
            //if (m_UserData != null)
            //{
            //    r_FormMain.SetAppAfterLogout();
            //    m_LoggedInUser = null;
            //    m_LoginResult = null;
            //}
        }
    }
}
