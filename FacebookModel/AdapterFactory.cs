using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class AdapterFactory : IAdapterFactory
    {
        public T CreateAdapter<T>(object apiObject)
        {
            if (typeof(T) == typeof(IPost) && apiObject is FacebookWrapper.ObjectModel.Post post)
            {
                return (T)(object)new PostAdapter(post);
            }
            else if (typeof(T) == typeof(IGroup) && apiObject is FacebookWrapper.ObjectModel.Group group)
            {
                return (T)(object)new GroupAdapter(group);
            }
            else if (typeof(T) == typeof(IEvent) && apiObject is FacebookWrapper.ObjectModel.Event i_event)
            {
                return (T)(object)new EventAdapter(i_event);
            }
            else if (typeof(T) == typeof(IPage) && apiObject is FacebookWrapper.ObjectModel.Page page)
            {
                return (T)(object)new PageAdapter(page);
            }
            else if (typeof(T) == typeof(IAlbum) && apiObject is FacebookWrapper.ObjectModel.Album album)
            {
                return (T)(object)new AlbumAdapter(album);
            }

            throw new ArgumentException("Invalid type or object");
        }
    }


    //3. Modify your existing `FacebookUser` class to use the factory:

    //csharp
    //public class FacebookUser : IFacebookUser
    //{
    //    // ... existing code ...

    //    private readonly IAdapterFactory m_AdapterFactory = new AdapterFactory();

    //    public void LoadPostsFromApi()
    //    {
    //        if (m_PostCollection == null)
    //        {
    //            m_PostCollection = new ObservableCollection<IPost>();
    //            foreach (FacebookWrapper.ObjectModel.Post apiPost in m_LogInUser.Posts)
    //            {
    //                IPost postToAdd = m_AdapterFactory.CreateAdapter<IPost>(apiPost);
    //                m_PostCollection.Add(postToAdd);
    //            }
    //        }
    //    }

    //    // Do the same for LoadGroupsFromApi(), LoadEventsFromApi(), LoadPagesFromApi(), and LoadAlbumsFromApi()
    //}

}
