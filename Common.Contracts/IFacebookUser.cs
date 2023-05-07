using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Contracts
{
    public interface IFacebookUser
    {
        string m_UserName { get; }
        string m_PictureURL { get; }
        ObservableCollection<IPost> m_PostCollection { get; set; }
        void LoadPostsFromApi();
    }
}
