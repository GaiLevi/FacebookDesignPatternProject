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
        ObservableCollection<IGroup> m_GroupCollection { get; set; }
        ObservableCollection<IEvent> m_EventCollection { get; set; }
        ObservableCollection<IPage> m_PageCollection { get; set; }
        void LoadPostsFromApi();
        void LoadGroupsFromApi();
        void LoadPagesFromApi();
        void LoadEventsFromApi();
    }
}
