using Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class NewFactory : IAdapterFactory
    {
        public IObject CreateAdapter(object i_ApiObject)
        {
            switch (i_ApiObject)
            {
                case FacebookWrapper.ObjectModel.Post post:
                    return new PostAdapter(post);
                case FacebookWrapper.ObjectModel.Group group:
                    return new GroupAdapter(group);
                case FacebookWrapper.ObjectModel.Event i_event:
                    return new EventAdapter(i_event);
                case FacebookWrapper.ObjectModel.Page page:
                    return new PageAdapter(page);
                case FacebookWrapper.ObjectModel.Album album:
                    return new AlbumAdapter(album);
                default:
                    throw new ArgumentException("Invalid type or object");
            }
        }

    }
}
