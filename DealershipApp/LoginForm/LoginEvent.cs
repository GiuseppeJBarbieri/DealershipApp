using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public delegate void LoginHandler(object sender, LoginEvent e);

    public class LoginEvent : EventArgs
    {
        public string username;
    }
}
