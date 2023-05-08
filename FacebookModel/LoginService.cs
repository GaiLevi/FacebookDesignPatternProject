using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookModel
{
    public class LoginService
    {
        public LoginResult m_LoginResult { get; set; }

        //public ObservableCollection<FacebookModel.Post> Posts { get; } = new ObservableCollection<Post>();

        //public void LoadPostsFromApi()
        //{

        //    // Convert API posts to Post objects and add to collection
        //    foreach (FacebookWrapper.ObjectModel.Post apiPost in m_LoggedInUser.Posts)
        //    {
        //        FacebookModel.Post post = new FacebookModel.Post(apiPost.Id, apiPost.Message);
        //        Posts.Add(post);
        //    }
        //}

        public UserData m_UserData { get; set; }

        private LoginService()
        {
        }

        public static LoginService Instance
        {
            get { return Singleton<LoginService>.Instance;}
        }

        public FacebookUser loginAndInit()
        {
            FacebookUser loggedInUser = null;
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
                    loggedInUser = new FacebookUser(m_LoginResult.LoggedInUser);
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return loggedInUser;
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
