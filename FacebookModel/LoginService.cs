using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public LoginResult m_LoginResult { get; set; }
        public FacebookUser m_LoginUser { get; set; }
        public string m_AccessToken { get; set; }

        //public ObservableCollection<FacebookModel.Post> Posts { get; } = new ObservableCollection<Post>();
        public UserData m_UserData { get; set; }

        private LoginService()
        {
        }

        public static LoginService Instance
        {
            get { return Singleton<LoginService>.Instance;}
        }


        public void AutoLogin(string i_AccessToken)
        {
            try
            {
                if (!string.IsNullOrEmpty(i_AccessToken))
                {
                    m_LoginResult = FacebookService.Connect(i_AccessToken);
                    m_LoginUser = new FacebookUser(m_LoginResult.LoggedInUser);
                    m_AccessToken = m_LoginResult.AccessToken;
                }
            }
            catch (Exception ex)
            {
                   LoginAndInit();
            }
        }


        public void LoginAndInit()
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
                    m_LoginUser = new FacebookUser(m_LoginResult.LoggedInUser);
                    m_AccessToken = m_LoginResult.AccessToken;
                }
                else
                {
                    throw new InvalidOperationException(m_LoginResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LogoutAndSet()
        {
            FacebookService.LogoutWithUI();
        }
    }
}
