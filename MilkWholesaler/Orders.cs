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
            ordersViewDataGridView.Columns["productDetailsColumn"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ordersViewDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void ordersViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersViewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.milk_WholesalerDataSet1);

        }

        private void button_complete_Click(object sender, EventArgs e)
        {
            if (ordersViewBindingSource.Current != null)
            {
                DataRowView currentRowView = (DataRowView)ordersViewBindingSource.Current;
                Milk_WholesalerDataSet1.OrdersViewRow currentRow = (Milk_WholesalerDataSet1.OrdersViewRow)currentRowView.Row;

                if (!currentRow.IsStatusNull() && currentRow.Status != "Completed")
                {
                    currentRow.Status = "Completed";

                    tableAdapterManager.UpdateAll(milk_WholesalerDataSet1);

                    MessageBox.Show("Order marked as completed.");
                }
                else
                {
                    MessageBox.Show("The selected order is already completed or no status available.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to complete.");
            }
        }
        private void UpdateFilters()
        {
            List<string> filterParts = new List<string>();

            if (!string.IsNullOrWhiteSpace(textBox_search.Text))
            {
                string searchText = textBox_search.Text.Replace("'", "''"); 
                if (radioButton_name.Checked)
                {
                    filterParts.Add($"SupplierName LIKE '%{searchText}%'");
                }
                else if (radioButton_details.Checked)
                {
                    filterParts.Add($"ProductDetails LIKE '%{searchText}%'");
                }
            }

            if (radioButton_greater.Checked)
            {
                filterParts.Add($"OrderDate > '{dateTimePicker_greater.Value.ToString("yyyy-MM-dd")}'");
            }
            else if (radioButton_lesser.Checked)
            {
                filterParts.Add($"OrderDate < '{dateTimePicker_greater.Value.ToString("yyyy-MM-dd")}'");
            }
            else if (radioButton_selected.Checked)
            {
                filterParts.Add($"OrderDate = '{dateTimePicker_greater.Value.ToString("yyyy-MM-dd")}'");
            }

            string combinedFilter = string.Join(" AND ", filterParts);
            ordersViewBindingSource.Filter = combinedFilter;
        }


        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }


        private void dateTimePicker_greater_ValueChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_greater_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_lesser_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_selected_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_details_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            
            textBox_search.Text = "";
            dateTimePicker_greater.Value = DateTime.Today;
            ordersViewBindingSource.Filter = "";
        }

        private void button_restock_Click(object sender, EventArgs e)
        {
            Form restock = new Restock(string.Empty);
            restock.ShowDialog();
        }

        private void ordersViewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
