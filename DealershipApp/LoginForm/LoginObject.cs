using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public class LoginObject
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginObject(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
