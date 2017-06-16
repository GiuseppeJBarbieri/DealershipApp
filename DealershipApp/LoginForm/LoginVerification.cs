using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    class LoginVerification
    {
        public LoginVerification(LoginObject account)
        {
            string username = account.Username;
            string password = account.Password;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-5CCJBGD;Initial Catalog=DealerDataBase;Integrated Security=True;Pooling=False";
            con.Open();

            SqlCommand cmd = new SqlCommand("select user_name,password from login where user_name='" + username + "'and password='" + password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage ");
                HomePageForm mainPage = new HomePageForm();
                LoginForm.ActiveForm.Hide();
                mainPage.Show();
                



            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();


        }
    }
}
