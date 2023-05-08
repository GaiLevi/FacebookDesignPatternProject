using Common.Contracts;
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

        private IFacebookUser m_FacebookUser;

        //private ObservableCollection<PostAdapter> m_posts;

        public BindingSource m_bsPosts;



        public event PropertyChangedEventHandler PropertyChanged;

        public LoginService LoginService
        {
            get => m_LoginService; set => SetField(ref m_LoginService, value);
        }

        public IFacebookUser FacebookUser
        {
            get => m_FacebookUser; set => SetField(ref m_FacebookUser, value);
        }

        //public ObservableCollection<PostAdapter> Posts
        //{
        //    get => m_posts; set => SetField(ref m_posts, value);
        //}

        public BindingSource bsPosts
        {
            get => m_bsPosts; set => SetField(ref m_bsPosts, value);
        }

       
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        public bool LoginButtonClicked()
        {
            bool isLogginSucceed = false;
            m_LoginService = LoginService.Instance;
            m_FacebookUser = m_LoginService.loginAndInit();
            if(m_FacebookUser != null)
            {
                isLogginSucceed = true;
                if(m_FacebookUser is FacebookUser)
                {
                    m_FacebookUser.LoadPostsFromApi();
                }
            }
            return isLogginSucceed;
            //m_LoginService.LoadPostsFromApi();
            //m_bsPosts = new BindingSource { DataSource = m_LoginService.Posts };

        }

        public void LogoutButtonClicked()
        {
            m_LoginService.LogoutAndSet();
        }


    }
}
