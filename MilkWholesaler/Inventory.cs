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
    public partial class Inventory : Form
    {
        private Form mainForm;

        public Inventory(Form main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milk_WholesalerDataSet1.InventoryView' table. You can move, or remove it, as needed.
            this.inventoryViewTableAdapter.Fill(this.milk_WholesalerDataSet1.InventoryView);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inventoryViewBindingSource.Filter = $"ProductName LIKE '%{textBox1.Text.Replace("'", "''")}%'";
        }

        private void inventoryViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == inventoryViewDataGridView.Columns["Restock"].Index)
            {
                // Get the ProductName of the selected row
                string productName = inventoryViewDataGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();

                Form restock = new Restock(productName);
                restock.ShowDialog();
                Inventory_Load(sender, e);
            }
        }
    }
}
