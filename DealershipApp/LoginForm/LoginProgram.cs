using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    class LoginProgram
    {

        public LoginProgram(string[] args)
        {
            WorkingClass wd = new WorkingClass();
            WireEventHandlers(wd);
            wd.DoWork();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private void WireEventHandlers(WorkingClass wd)
        {
            LoginHandler handler = new LoginHandler(OnHandler1);
           wd.LoginEvent += handler;
        }

        public void OnHandler1(object sender, LoginEvent e)
        {
            Console.WriteLine(e.username);
            
        }
    }
}
