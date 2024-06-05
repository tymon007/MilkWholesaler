using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkWholesaler
{
    public partial class Orders : Form
    {
        private Form mainForm;

        public Orders(Form main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }


        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milk_WholesalerDataSet1.OrdersView' table. You can move, or remove it, as needed.
            this.ordersViewTableAdapter.Fill(this.milk_WholesalerDataSet1.OrdersView);

        }

        private void ordersViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersViewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.milk_WholesalerDataSet1);

        }
    }
}
