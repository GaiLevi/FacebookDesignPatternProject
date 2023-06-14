using Common.Contracts;
using FacebookModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public static LoginService m_LoginService;
        private IFacebookUser m_FacebookUser;
        public DateTime m_AppStarTime { get; set; }
        public TimeWellSpend m_TimeWellSpend { get; set; }
        public BindingSource m_BindingSourcePosts;
        public event PropertyChangedEventHandler PropertyChanged;
        private string m_AccessToken;
        public event Action NewPostAdded;

        public string AccessToken
        {
            get => m_AccessToken;
            set
            {
                if(m_AccessToken != value)
                {
                    m_AccessToken = value;
                    OnPropertyChanged(nameof(AccessToken));
                }
            }
        }

        public LoginService LoginService
        {
            get => m_LoginService;
            set
            {
                if (m_LoginService != value)
                {
                    m_LoginService = value;
                    OnPropertyChanged(nameof(LoginService));
                }
            }
        }

        public IFacebookUser FacebookUser
        {
            get => m_FacebookUser;
            set
            {
                if(m_FacebookUser != value)
                {
                    m_FacebookUser = value;
                    OnPropertyChanged(nameof(FacebookUser));
                }
            }
        }

        public BindingSource BindingSourcePosts
        {
            get => m_BindingSourcePosts;
            set
            {
                if (m_BindingSourcePosts != value)
                {
                    m_BindingSourcePosts = value;
                    OnPropertyChanged(nameof(BindingSourcePosts));
                }
            }
        }

        protected virtual void OnPropertyChanged(string i_PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(i_PropertyName));
        }



        public void AddNewPost(string i_PostMessage)
        {
            FacebookUser.AddNewPostToCollection(i_PostMessage);
            OnNewPostAdded();
        }

        protected virtual void OnNewPostAdded()
        {
            NewPostAdded?.Invoke();
        }

        public void AutoLogin(string i_AccessToken)
        {
            try
            {
                m_LoginService = LoginService.Instance;
                m_LoginService.AutoLogin(i_AccessToken);
                m_FacebookUser = m_LoginService.m_LoginUser;
                doAfterLogin(m_FacebookUser);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void doAfterLogin(IFacebookUser i_LoginUser)
        {
            if (i_LoginUser != null)
            {
                AccessToken = m_LoginService.m_AccessToken;
            }
        }

        public void LoginButtonClicked()
        {
            try
            {
                m_LoginService = LoginService.Instance;
                m_LoginService.LoginAndInit();
                m_FacebookUser = m_LoginService.m_LoginUser;
                doAfterLogin(m_FacebookUser);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LogoutButtonClicked()
        {
            m_LoginService.LogoutAndSet();
        }

        public string SetTimersMSG()
        {
            DateTime now = DateTime.Now;
            TimeSpan timePast = now - m_AppStarTime;
            string appUsingTime = string.Format(
                @"{0} days,
{1} hours,
{2} minutes,
{3} seconds
of your life in our stupid App!",
                timePast.Days,
                timePast.Hours,
                timePast.Minutes,
                timePast.Seconds);
            return appUsingTime;
        }

        public string GetBetterThingFromDic()
        {
            if (m_TimeWellSpend == null)
            {
                m_TimeWellSpend = new TimeWellSpend();
            }
            string betterThingToDo = m_TimeWellSpend.GetActivity(m_AppStarTime);
            return betterThingToDo;
        }

        public class ImageURLIterator : IEnumerator<string>
        {
            private readonly ObservableCollection<string> urlCollection;
            private int index = -1;

            public ImageURLIterator(ObservableCollection<string> urlCollection)
            {
                this.urlCollection = urlCollection;
            }

            public string Current => urlCollection[index];

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                index++;
                return (index < urlCollection.Count);
            }

            public void Reset()
            {
                index = -1;
            }

            public bool MovePrevious()
            {
                if (index > 0)
                {
                    index--;
                    return true;
                }
                return false;
            }
        }
    }
}
