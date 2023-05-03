using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookModel;

namespace FacebookViewModel
{
    public class ViewModel
    {
        public LoginService m_LoginService;

        public void LoginButtonClicked()
        {
            m_LoginService = new LoginService();
            
        }

        public void LogoutButtonClicked()
        {
            m_LoginService.LogoutAndSet();
        }
    }
}
