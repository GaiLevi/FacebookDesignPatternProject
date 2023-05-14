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
}
