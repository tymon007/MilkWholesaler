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
        List<OrderDetail> orderDetails = new List<OrderDetail>();

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
            UpdateFilters();
        }
        private void UpdateFilters()
        {
            List<string> filterParts = new List<string>();

            if (!string.IsNullOrWhiteSpace(textBox_search.Text))
            {
                string searchText = textBox_search.Text.Replace("'", "''");
                filterParts.Add($"ProductName LIKE '%{searchText}%'");
            }
            if (!string.IsNullOrWhiteSpace(textBox_supplier.Text))
            {
                string searchText = textBox_supplier.Text.Replace("'", "''");
                filterParts.Add($"SupplierName LIKE '%{searchText}%'");
            }

            string combinedFilter = string.Join(" AND ", filterParts);
            offersViewBindingSource.Filter = combinedFilter;
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

                    foreach (OrderItem item in orderItems)
                    {
                        if (item.ProductID == newItem.ProductID)
                        {
                            item.Quantity += newItem.Quantity;
                            checkedListBox1.Items.Clear();
                            foreach (OrderItem orderItem in orderItems)
                            {
                                string listItem1 = $"{orderItem.ProductName} - Quantity: {orderItem.Quantity}";
                                checkedListBox1.Items.Add(listItem1, false);
                            }
                            return;
                        }
                    }

                    orderItems.Add(newItem);

                    string listItem = $"{newItem.ProductName} - Quantity: {newItem.Quantity}";
                    checkedListBox1.Items.Add(listItem, false);
                    textBox_supplier.Text = currentRow["SupplierName"].ToString();
                    textBox_supplier.Enabled = false;
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

        private void button_complete_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Please select at least one product to order.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal sum_price = 0;

            foreach (OrderItem item in orderItems)
            {
                sum_price += item.UnitPrice * item.Quantity;
            }
            Order newOrder = new Order
            {
                OrderDate = DateTime.Now,
                Status = "Pending",
                TotalPrice = sum_price,
                SupplierID = orderItems[0].SupplierID
            };

            var newOrderRow = milk_WholesalerDataSet1.Orders.NewOrdersRow();

            newOrderRow.SupplierID = newOrder.SupplierID;
            newOrderRow.OrderDate = newOrder.OrderDate;
            newOrderRow.Status = newOrder.Status;
            newOrderRow.TotalPrice = newOrder.TotalPrice;

            milk_WholesalerDataSet1.Orders.AddOrdersRow(newOrderRow);

            ordersTableAdapter1.Update(milk_WholesalerDataSet1.Orders);
            int newOrderID = Convert.ToInt32(newOrderRow.OrderID);

            foreach (OrderItem item in orderItems)
            {
                var newDetailRow = milk_WholesalerDataSet1.OrderDetails.NewOrderDetailsRow();

                OrderDetail newOrderDetail = new OrderDetail
                {
                    OrderID = newOrderID,
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };
                newDetailRow.OrderID = newOrderDetail.OrderID;
                newDetailRow.ProductID = newOrderDetail.ProductID;
                newDetailRow.Quantity = newOrderDetail.Quantity;
                newDetailRow.UnitPrice = newOrderDetail.UnitPrice;
                milk_WholesalerDataSet1.OrderDetails.AddOrderDetailsRow(newDetailRow);   
            }
            orderDetailsTableAdapter1.Update(milk_WholesalerDataSet1.OrderDetails);
            orderItems.Clear();
            checkedListBox1.Items.Clear();
        }

        private void textBox_supplier_TextChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    List<OrderItem> itemsToRemove = new List<OrderItem>();

                    foreach (OrderItem item in orderItems)
                    {
                        if (checkedListBox1.Items[e.Index].ToString().Contains(item.ProductName))
                        {
                            itemsToRemove.Add(item);
                        }
                    }

                    foreach (OrderItem item in itemsToRemove)
                    {
                        orderItems.Remove(item);
                    }

                    checkedListBox1.Items.RemoveAt(e.Index);
                }
            }));


        }
    }
}
