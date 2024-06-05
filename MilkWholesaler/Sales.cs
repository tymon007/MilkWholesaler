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
    }
}
