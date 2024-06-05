using MilkWholesaler.Milk_WholesalerDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MilkWholesaler
{
    public partial class Restock : Form
    {
        private string productName;
        List<OrderItem> orderItems = new List<OrderItem>();

        public Restock(string productName)
        {
            InitializeComponent();
            this.productName = productName;
        }

        private void Restock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milk_WholesalerDataSet1.OffersView' table. You can move, or remove it, as needed.
            this.offersViewTableAdapter.Fill(this.milk_WholesalerDataSet1.OffersView);
            textBox_search.Text = productName;
            offersViewBindingSource.Filter = $"ProductName LIKE '%{textBox_search.Text.Replace("'", "''")}%'";
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            offersViewBindingSource.Filter = $"ProductName LIKE '%{textBox_search.Text.Replace("'", "''")}%'";
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (offersViewBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)offersViewBindingSource.Current;

                int quantity = (int)numericUpDown_quantity.Value;

                if (quantity > 0)
                {
                    OrderItem newItem = new OrderItem
                    {
                        ProductID = Convert.ToInt32(currentRow["ProductID"]),
                        SupplierID = Convert.ToInt32(currentRow["SupplierID"]),
                        ProductName = currentRow["ProductName"].ToString(),
                        Quantity = (int)numericUpDown_quantity.Value,
                        UnitPrice = Convert.ToDecimal(currentRow["SupplierPrice"])
                    };
                    orderItems.Add(newItem);

                    string listItem = $"{newItem.ProductName} - Quantity: {newItem.Quantity}";
                    checkedListBox1.Items.Add(listItem, false);  
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
