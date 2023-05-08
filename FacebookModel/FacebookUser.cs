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
        public ObservableCollection<IGroup> m_GroupCollection { get; set; }
        public ObservableCollection<IEvent> m_EventCollection { get; set; }
        public ObservableCollection<IPage> m_PageCollection { get; set; }

        public FacebookUser(User i_LoggedInUser)
        {
            m_LogInUser = i_LoggedInUser;
            m_UserName = i_LoggedInUser.Name;
            m_PictureURL = i_LoggedInUser.PictureNormalURL;
            //m_PostCollection = new ObservableCollection<IPost>(); 
        }

        public void LoadPostsFromApi()
        {
            if (m_PostCollection == null)
            {
                m_PostCollection = new ObservableCollection<IPost>();
                foreach (FacebookWrapper.ObjectModel.Post apiPost in m_LogInUser.Posts)
                {
                    PostAdapter post = new PostAdapter(apiPost);
                    m_PostCollection.Add(post);
                }
            }
        }

        public void LoadGroupsFromApi()
        {
            if (m_GroupCollection == null)
            {
                m_GroupCollection = new ObservableCollection<IGroup>();
                foreach (FacebookWrapper.ObjectModel.Group apiGroup in m_LogInUser.Groups)
                {
                    GroupAdapter group = new GroupAdapter(apiGroup);
                    m_GroupCollection.Add(group);
                }
            }
        }
        public void LoadEventsFromApi()
        {
            if (m_EventCollection == null)
            {
                m_EventCollection = new ObservableCollection<IEvent>();
                foreach (FacebookWrapper.ObjectModel.Event apiEvent in m_LogInUser.Events)
                {
                    EventAdapter eventToAdd = new EventAdapter(apiEvent);
                    m_EventCollection.Add(eventToAdd);
                }
            }
        }

        public void LoadPagesFromApi()
        {
            if (m_PageCollection == null)
            {
                m_PageCollection = new ObservableCollection<IPage>();
                foreach (FacebookWrapper.ObjectModel.Page apiPage in m_LogInUser.LikedPages)
                {
                    PageAdapter page = new PageAdapter(apiPage);
                    m_PageCollection.Add(page);
                }
            }
        }
    }
}
