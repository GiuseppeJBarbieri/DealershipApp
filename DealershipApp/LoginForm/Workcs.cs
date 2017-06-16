using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class WorkingClass
    {
        
        public WorkingClass()
        {

        }

        public void DoWork()
        {
            FireEvent("Here");
        }

        private void FireEvent(string message)
        {
            LoginEvent loginEv = new LoginEvent();

            loginEv.username = "ayo";
            if(LoginEvent != null)
            {
                LoginEvent(this, loginEv);

            }
            loginEv = null;
        }
    }

 
}
