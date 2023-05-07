using Common.Contracts;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class FacebookUser : IFacebookUser
    {
        private readonly User m_LogInUser;
        public string m_UserName { get; }
        public string m_PictureURL { get; }

        public ObservableCollection<IPost> m_PostCollection { get; set; }

        public FacebookUser(User i_LoggedInUser)
        {
            m_LogInUser = i_LoggedInUser;
            m_UserName = i_LoggedInUser.UserName;
            m_PictureURL = i_LoggedInUser.PictureNormalURL;
            m_PostCollection = new ObservableCollection<IPost>(); 
        }

        public void LoadPostsFromApi()
        {
            foreach (FacebookWrapper.ObjectModel.Post apiPost in m_LogInUser.Posts)
            {
                PostAdapter post = new PostAdapter(apiPost);
                m_PostCollection.Add(post);
            }
        }
    }
}
