using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MilkWholesaler
{
    public partial class Inventory : Form
    {
        private Form mainForm;
        private Timer colorTimer;

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
            this.inventoryViewTableAdapter.Fill(this.milk_WholesalerDataSet1.InventoryView);
            colorTimer = new Timer();
            colorTimer.Interval = 5000;
            colorTimer.Tick += ColorTimer_Tick;
            colorTimer.Start();
            AddRemoveButtonColumn();
            ApplyExpirationColorCoding();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            inventoryViewBindingSource.Filter = $"ProductName LIKE '%{textBox_search.Text.Replace("'", "''")}%'";
        }

        private void inventoryViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && inventoryViewDataGridView.Columns[e.ColumnIndex].Name == "Remove")
            {
                var result = MessageBox.Show("Are you sure you want to remove this expired product?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {


                    int rowID = (int)inventoryViewDataGridView.Rows[e.RowIndex].Cells["InventoryID"].Value;
                    DataGridViewRow row = inventoryViewDataGridView.Rows[rowID-1];


                    string columnName3 = "dataGridViewTextBoxColumn2";
                    string columnName4 = "dataGridViewTextBoxColumn3";
                    string columnName5 = "dataGridViewTextBoxColumn4";

                    int quantityOnHand = (int)row.Cells[columnName3].Value; 
                    DateTime expirationDate = (DateTime)row.Cells[columnName4].Value; 
                    string warehouseLocation = (string)row.Cells[columnName5].Value;

                    DateTime myDateTime = new DateTime(2025, 1, 1);
                    inventoryTableAdapter1.Delete(rowID, rowID, quantityOnHand, expirationDate, warehouseLocation);
                    this.inventoryViewTableAdapter.Fill(this.milk_WholesalerDataSet1.InventoryView);
                }
            }
            else if (e.RowIndex >= 0 && inventoryViewDataGridView.Columns[e.ColumnIndex].Name == "Restock")
            {
                string productName = inventoryViewDataGridView.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                Form restock = new Restock(productName);
                restock.ShowDialog();
                this.inventoryViewTableAdapter.Fill(this.milk_WholesalerDataSet1.InventoryView);
            }
        }

        private void ApplyExpirationColorCoding()
        {
            foreach (DataGridViewRow row in inventoryViewDataGridView.Rows)
            {
                if (row.DataBoundItem != null && row.DataBoundItem is DataRowView rowView)
                {
                    DateTime expirationDate = (DateTime)rowView["ExpirationDate"];
                    DateTime today = DateTime.Today;
                    if (expirationDate < today)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            ApplyExpirationColorCoding();
        }

        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (colorTimer != null)
            {
                colorTimer.Stop();
                colorTimer.Dispose();
            }
        }

        private void AddRemoveButtonColumn()
        {
            if (inventoryViewDataGridView.Columns["Remove"] == null)
            {
                DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Remove",
                    Text = "Remove",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Actions"
                };

                inventoryViewDataGridView.Columns.Add(removeButtonColumn);
            }
        }
    }
}
