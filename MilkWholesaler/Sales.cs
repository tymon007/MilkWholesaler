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
            if (salesViewDataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = salesViewDataGridView.SelectedRows[0].Index;
                DataRow row = dataSet.Tables["Sales"].Rows[selectedRowIndex];

                if (row.RowState != DataRowState.Deleted)
                {
                    row["Status"] = "Completed";
                }

                // Update the database
                adapter.Update(dataSet, "Sales");

                MessageBox.Show("Sale marked as completed.");
            }
            else
            {
                MessageBox.Show("Please select a sale to complete.");
            }
        }
    }
}
