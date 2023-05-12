using Common.Contracts;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        public ObservableCollection<IAlbum> m_AlbumCollection { get; set; }
        private readonly IAdapterFactory m_AdapterFactory = new AdapterFactory();
        public FacebookUser(User i_LoggedInUser)
        {
            m_LogInUser = i_LoggedInUser;
            m_UserName = i_LoggedInUser.Name;
            m_PictureURL = i_LoggedInUser.PictureNormalURL;
        }
        public void AddNewPostToCollection(string i_PostMessage)
        {
            IPost newPost = new PostAdapter(i_PostMessage);
            m_PostCollection.Insert(0,newPost);
        }
        public void LoadPostsFromApi()
        {
            if (m_PostCollection == null)
            {
                m_PostCollection = new ObservableCollection<IPost>();

                foreach (FacebookWrapper.ObjectModel.Post apiPost in m_LogInUser.Posts)
                {
                    IPost postToAdd = m_AdapterFactory.CreateAdapter<IPost>(apiPost);
                    m_PostCollection.Add(postToAdd);
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
                    IGroup groupToAdd = m_AdapterFactory.CreateAdapter<IGroup>(apiGroup);
                    m_GroupCollection.Add(groupToAdd);
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
                    IEvent eventToAdd = m_AdapterFactory.CreateAdapter<IEvent>(apiEvent);
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
                    IPage pageToAdd = m_AdapterFactory.CreateAdapter<IPage>(apiPage);
                    m_PageCollection.Add(pageToAdd);
                }
            }
        }
        public void LoadAlbumsFromApi()
        {
            if (m_AlbumCollection == null)
            {
                m_AlbumCollection = new ObservableCollection<IAlbum>();
                foreach (FacebookWrapper.ObjectModel.Album apiAlbum in m_LogInUser.Albums)
                {
                    IAlbum albumToAdd = m_AdapterFactory.CreateAdapter<IAlbum>(apiAlbum);
                    m_AlbumCollection.Add(albumToAdd);
                }
            }
        }
    }
}
