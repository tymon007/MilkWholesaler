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
            if (salesViewBindingSource.Current != null)
            {
                DataRowView currentRowView = (DataRowView)salesViewBindingSource.Current;
                Milk_WholesalerDataSet1.SalesViewRow currentRow = (Milk_WholesalerDataSet1.SalesViewRow)currentRowView.Row;

                if (!currentRow.IsStatusNull() && currentRow.Status != "Completed")
                {
                    currentRow.Status = "Completed";

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
        private void filterDate()
        {
            string dateFilter = dateTimePicker_greater.Value.ToString("yyyy-MM-dd");

            if (radioButton_greater.Checked)
            {
                salesViewBindingSource.Filter = $"SaleDate > '{dateFilter}'";
            }
            else if (radioButton_lesser.Checked)
            {
                salesViewBindingSource.Filter = $"SaleDate < '{dateFilter}'";
            }
            else if (radioButton_selected.Checked)
            {
                salesViewBindingSource.Filter = $"SaleDate = '{dateFilter}'";
            }
        }
        private void filterSearch()
        {
            string searchText = textBox_search.Text.Replace("'", "''");
            if (radioButton_name.Checked)
            {
                salesViewBindingSource.Filter = $"ClientName LIKE '%{searchText}%'";
            }
            else if (radioButton_details.Checked)
            {
                salesViewBindingSource.Filter = $"Details LIKE '%{searchText}%'";
            }
        }

        private void dateTimePicker_greater_ValueChanged(object sender, EventArgs e)
        {
            filterDate();
        }

        private void radioButton_greater_CheckedChanged(object sender, EventArgs e)
        {
            filterDate();
        }

        private void radioButton_lesser_CheckedChanged(object sender, EventArgs e)
        {
            filterDate();
        }

        private void radioButton_selected_CheckedChanged(object sender, EventArgs e)
        {
            filterDate();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            filterSearch();
        }

        private void radioButton_details_CheckedChanged(object sender, EventArgs e)
        {
            filterSearch();
        }

        private void radioButton_name_CheckedChanged(object sender, EventArgs e)
        {
            filterSearch();
        }
    }
}
