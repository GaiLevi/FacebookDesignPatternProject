using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public interface IUserData
    {
        string m_UserName { get; }
        string m_PictureURL { get; }

        //List<Post> GetPosts();
        //List<Event> GetEvents();
        //List<Album> GetAlbums();
        //List<Group> GetGroups();

    }
}
