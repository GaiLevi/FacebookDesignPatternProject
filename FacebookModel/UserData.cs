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

        public event PropertyChangedEventHandler PropertyChanged;

        public UserData()
        {

        }

        protected virtual void OnPropertyChanged(string i_PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(i_PropertyName));
        }
    }
}
