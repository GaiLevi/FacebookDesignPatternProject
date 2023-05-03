using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    class UserData : IUserData
    {
        public string m_UserName { get; }

        public string m_PictureURL { get; }
        public UserData(User i_LoggedInUser)
        {
            m_UserName = i_LoggedInUser.Name;
            m_PictureURL = i_LoggedInUser.PictureNormalURL;
        }
    }
}
