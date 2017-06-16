using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.Views
{
    public partial class CarsInStock : Form
    {
        private object dealerDataBaseDataSet;

        public CarsInStock()
        {
            InitializeComponent();
        }

        private void CarsInStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carInventory.car_db' table. You can move, or remove it, as needed.
            this.car_dbTableAdapter.Fill(this.carInventory.car_db);
            // TODO: This line of code loads data into the 'dealerDataBaseDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dealerDataBaseDataSet.login);

        }
    }
}
