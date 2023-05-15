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
        private readonly User r_LogInUser;
        public string m_UserName { get; }
        public string m_PictureURL { get; }
        public ObservableCollection<IPost> m_PostCollection { get; set; }
        public ObservableCollection<IGroup> m_GroupCollection { get; set; }
        public ObservableCollection<IEvent> m_EventCollection { get; set; }
        public ObservableCollection<IPage> m_PageCollection { get; set; }
        public ObservableCollection<IAlbum> m_AlbumCollection { get; set; }
        private readonly IAdapterFactory r_AdapterFactory = new AdapterFactory();

        public FacebookUser(User i_LoggedInUser)
        {
            r_LogInUser = i_LoggedInUser;
            m_UserName = i_LoggedInUser.Name;
            m_PictureURL = i_LoggedInUser.PictureNormalURL;
        }

        public void AddNewPostToCollection(string i_PostMessage)
        {
            IPost newPost = new PostAdapter(i_PostMessage);
            m_PostCollection.Insert(0,newPost);
        }

        public void LoadFromApi<T>(ObservableCollection<T> i_Collection, IEnumerable<object> i_ApiCollection) where T : IObject
        {
            foreach (object apiItem in i_ApiCollection)
            {
                T itemToAdd = (T)r_AdapterFactory.CreateAdapter(apiItem);
                i_Collection.Add(itemToAdd);
            }
        }

        public void LoadCollection<T>() where T : class, IObject
        {
            ObservableCollection<T> collection = null;
            IEnumerable<object> apiCollection;

            switch (typeof(T).Name)
            {
                case nameof(IPost):
                    if (m_PostCollection == null)
                    {
                        m_PostCollection = new ObservableCollection<IPost>();
                    }
                    collection = m_PostCollection as ObservableCollection<T>;
                    apiCollection = r_LogInUser.Posts;
                    break;
                case nameof(IGroup):
                    if (m_GroupCollection == null)
                    {
                        m_GroupCollection = new ObservableCollection<IGroup>();
                    }
                    collection = m_GroupCollection as ObservableCollection<T>;
                    apiCollection = r_LogInUser.Groups;
                    break;
                case nameof(IPage):
                    if (m_PageCollection == null)
                    {
                        m_PageCollection = new ObservableCollection<IPage>();
                    }
                    collection = m_PageCollection as ObservableCollection<T>;
                    apiCollection = r_LogInUser.LikedPages;
                    break;
                case nameof(IAlbum):
                    if (m_AlbumCollection == null)
                    {
                        m_AlbumCollection = new ObservableCollection<IAlbum>();
                    }
                    collection = m_AlbumCollection as ObservableCollection<T>;
                    apiCollection = r_LogInUser.Albums;
                    break;
                case nameof(IEvent):
                    if (m_EventCollection == null)
                    {
                        m_EventCollection = new ObservableCollection<IEvent>();
                    }
                    collection = m_EventCollection as ObservableCollection<T>;
                    apiCollection = r_LogInUser.Events;
                    break;
                default:
                    throw new ArgumentException("Invalid type");
            }

            if (collection == null)
            {
                throw new InvalidOperationException($"Failed to cast collection to ObservableCollection<{typeof(T).Name}>");
            }

            LoadFromApi(collection, apiCollection);
        }
    }
}

