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
        //public T CreateAdapter<T>(object apiObject)
        //{
        //    if (typeof(T) == typeof(IPost) && apiObject is FacebookWrapper.ObjectModel.Post post)
        //    {
        //        return (T)(object)new PostAdapter(post);
        //    }
        //    else if (typeof(T) == typeof(IGroup) && apiObject is FacebookWrapper.ObjectModel.Group group)
        //    {
        //        return (T)(object)new GroupAdapter(group);
        //    }
        //    else if (typeof(T) == typeof(IEvent) && apiObject is FacebookWrapper.ObjectModel.Event i_event)
        //    {
        //        return (T)(object)new EventAdapter(i_event);
        //    }
        //    else if (typeof(T) == typeof(IPage) && apiObject is FacebookWrapper.ObjectModel.Page page)
        //    {
        //        return (T)(object)new PageAdapter(page);
        //    }
        //    else if (typeof(T) == typeof(IAlbum) && apiObject is FacebookWrapper.ObjectModel.Album album)
        //    {
        //        return (T)(object)new AlbumAdapter(album);
        //    }

        //    throw new ArgumentException("Invalid type or object");
        //}
        public T CreateAdapter<T>(object i_ApiObject)
        {
            switch (i_ApiObject)
            {
                case FacebookWrapper.ObjectModel.Post post when typeof(T) == typeof(IPost):
                    return (T)(object)new PostAdapter(post);
                case FacebookWrapper.ObjectModel.Group group when typeof(T) == typeof(IGroup):
                    return (T)(object)new GroupAdapter(group);
                case FacebookWrapper.ObjectModel.Event i_event when typeof(T) == typeof(IEvent):
                    return (T)(object)new EventAdapter(i_event);
                case FacebookWrapper.ObjectModel.Page page when typeof(T) == typeof(IPage):
                    return (T)(object)new PageAdapter(page);
                case FacebookWrapper.ObjectModel.Album album when typeof(T) == typeof(IAlbum):
                    return (T)(object)new AlbumAdapter(album);
                default:
                    throw new ArgumentException("Invalid type or object");
            }
        }

    }


////////////this code bellow using 'when' which is advanced C#//////////////////


    //public T CreateAdapter<T>(object apiObject)
    //{
    //    switch (apiObject)
    //    {
    //        case FacebookWrapper.ObjectModel.Post post when typeof(T) == typeof(IPost):
    //            return (T)(object)new PostAdapter(post);
    //        case FacebookWrapper.ObjectModel.Group group when typeof(T) == typeof(IGroup):
    //            return (T)(object)new GroupAdapter(group);
    //        case FacebookWrapper.ObjectModel.Event i_event when typeof(T) == typeof(IEvent):
    //            return (T)(object)new EventAdapter(i_event);
    //        case FacebookWrapper.ObjectModel.Page page when typeof(T) == typeof(IPage):
    //            return (T)(object)new PageAdapter(page);
    //        case FacebookWrapper.ObjectModel.Album album when typeof(T) == typeof(IAlbum):
    //            return (T)(object)new AlbumAdapter(album);
    //        default:
    //            throw new ArgumentException("Invalid type or object");
    //    }
    //}


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
