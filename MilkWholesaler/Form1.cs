using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkWholesaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            Form inventory = new Inventory(this);
            inventory.Show();
            this.Hide();
        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            Form orders = new Orders(this);
            orders.Show();
            this.Hide();
        }

        private void button_sales_Click(object sender, EventArgs e)
        {
            Form sales = new Sales(this);
            sales.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
