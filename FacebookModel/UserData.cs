using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookModel
{
    public class UserData : INotifyPropertyChanged
    {
        public string m_UserName { 
            get { return m_UserName; } 
            set {
                    if (m_UserName != value)
                    {
                        m_UserName = value;
                        OnPropertyChanged("UserName");
                    }
            } 
        }

        public string m_PictureURL
        {
            get { return m_PictureURL; }
            set
            {
                if (m_PictureURL != value)
                {
                    m_PictureURL = value;
                    OnPropertyChanged("PictureURL");
                }
            }
        }
        //public UserData(User i_LoggedInUser)
        //{

        //    m_UserName = i_LoggedInUser.Name;
        //    m_PictureURL = i_LoggedInUser.PictureNormalURL;
        //}
        public UserData()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
