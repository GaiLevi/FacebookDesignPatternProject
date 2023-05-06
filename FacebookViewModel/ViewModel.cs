using FacebookModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FacebookWrapper.ObjectModel;

namespace FacebookViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public static LoginService m_LoginService;

        private ObservableCollection<Post> m_posts;

        public BindingSource m_bsPosts;

        //public User m_User;


        public event PropertyChangedEventHandler PropertyChanged;

        public LoginService LoginService
        {
            get => m_LoginService; set => SetField(ref m_LoginService, value);
        }

        public ObservableCollection<Post> Posts
        {
            get => m_posts; set => SetField(ref m_posts, value);
        }

        public BindingSource bsPosts
        {
            get => m_bsPosts; set => SetField(ref m_bsPosts, value);
        }

        //public User User
        //{
        //    get => m_User; set => SetField(ref m_User, value);
        //}
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public ObservableCollection<Post> GetPosts()
        //{
        //    ObservableCollection<Post> urn = null;
        //    if (!string.IsNullOrEmpty(m_LoginService.m_LoginResult.AccessToken))
        //    {
        //        urn = LoginService.m_LoggedInUser.Posts;
        //    }
        //    return urn;
        //}

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public void LoginButtonClicked()
        {
            m_LoginService = LoginService.Instance;
            //m_User = m_LoginService.m_LoggedInUser;
            m_LoginService.LoadPostsFromApi();
            //m_posts = m_LoginService.Posts;
            m_bsPosts = new BindingSource { DataSource = m_LoginService.Posts };

        }

        public void LogoutButtonClicked()
        {
            m_LoginService.LogoutAndSet();
        }


    }
}
