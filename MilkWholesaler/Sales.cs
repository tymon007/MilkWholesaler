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

namespace MilkWholesaler
{
    public partial class Sales : Form
    {
        private Form mainForm;

        public Sales(Form main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milk_WholesalerDataSet1.SalesView' table. You can move, or remove it, as needed.
            this.salesViewTableAdapter.Fill(this.milk_WholesalerDataSet1.SalesView);

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void button_complete_Click(object sender, EventArgs e)
        {
            salesDetailsTableAdapter1.Fill(milk_WholesalerDataSet1.SalesDetails);
            inventoryTableAdapter1.Fill(milk_WholesalerDataSet1.Inventory);

            if (salesViewBindingSource.Current != null)
            {
                DataRowView currentRowView = (DataRowView)salesViewBindingSource.Current;
                Milk_WholesalerDataSet1.SalesViewRow currentRow = (Milk_WholesalerDataSet1.SalesViewRow)currentRowView.Row;

                if (!currentRow.IsStatusNull() && currentRow.Status != "Completed")
                {
                    currentRow.Status = "Completed";

                    int[] detailIDs = currentRow.SaleDetailIDs.Split(',').Select(int.Parse).ToArray();

                    List<Milk_WholesalerDataSet1.SalesDetailsRow> saleDetails = new List<Milk_WholesalerDataSet1.SalesDetailsRow>();
                    foreach (int detailID in detailIDs)
                    {
                        Milk_WholesalerDataSet1.SalesDetailsRow detailRow = milk_WholesalerDataSet1.SalesDetails.FindBySaleDetailID(detailID);
                        saleDetails.Add(detailRow);
                    }

                    foreach (Milk_WholesalerDataSet1.SalesDetailsRow row in saleDetails)
                    {
                        var invRows = milk_WholesalerDataSet1.Inventory.Select($"ProductID = {row.ProductID}");
                        if (invRows.Length > 0)
                        {
                            Milk_WholesalerDataSet1.InventoryRow invRow = (Milk_WholesalerDataSet1.InventoryRow)invRows[0];
                            invRow.QuantityOnHand -= row.Quantity;
                        }
                    }
                    inventoryTableAdapter1.Update(milk_WholesalerDataSet1.Inventory);
                    tableAdapterManager.UpdateAll(milk_WholesalerDataSet1);

                    MessageBox.Show("Sale marked as completed.");
                }
                else
                {
                    MessageBox.Show("The selected sale is already completed or no status available.");
                }
            }
            else
            {
                MessageBox.Show("Please select a sale to complete.");
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
                    filterParts.Add($"ClientName LIKE '%{searchText}%'");
                }
                else if (radioButton_details.Checked)
                {
                    filterParts.Add($"Details LIKE '%{searchText}%'");
                }
            }

            if (radioButton_greater.Checked)
            {
                filterParts.Add($"SaleDate > '{dateTimePicker_greater.Value.ToString("yyyy-MM-dd")}'");
            }
            else if (radioButton_lesser.Checked)
            {
                filterParts.Add($"SaleDate < '{dateTimePicker_greater.Value.ToString("yyyy-MM-dd")}'");
            }
            else if (radioButton_selected.Checked)
            {
                filterParts.Add($"SaleDate = '{dateTimePicker_greater.Value.ToString("yyyy-MM-dd")}'");
            }

            string combinedFilter = string.Join(" AND ", filterParts);
            salesViewBindingSource.Filter = combinedFilter;
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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_details_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void radioButton_name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilters();
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            dateTimePicker_greater.Value = DateTime.Today;
            salesViewBindingSource.Filter = "";
        }
    }
}
