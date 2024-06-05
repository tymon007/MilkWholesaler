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
    }
}
