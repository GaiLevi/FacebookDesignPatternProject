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
    public class FacebookUserBuilder
    {
        private User m_LoggedInUser;
        private ObservableCollection<IPost> m_PostCollection;

        public void SetLoggedInUser(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public void LoadPostsFromApi()
        {
            m_PostCollection = new ObservableCollection<IPost>();

            foreach (FacebookWrapper.ObjectModel.Post apiPost in m_LoggedInUser.Posts)
            {
                PostAdapter post = new PostAdapter(apiPost);
                m_PostCollection.Add(post);
            }
        }

        public FacebookUser Build()
        {
            if (m_LoggedInUser == null)
            {
                throw new InvalidOperationException("LoggedInUser must be set before building a FacebookUser.");
            }

            FacebookUser user = new FacebookUser(m_LoggedInUser)
            {
                m_PostCollection = m_PostCollection,
            };

            return user;
        }
    }
}
