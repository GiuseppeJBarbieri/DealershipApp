﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginVerification(new LoginObject(usernameTxt.Text, passwordTxt.Text));
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
