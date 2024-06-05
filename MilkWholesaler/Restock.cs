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
    public partial class Restock : Form
    {
        public Restock(string productName)
        {
            InitializeComponent();
        }

        private void Restock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milk_WholesalerDataSet1.OffersView' table. You can move, or remove it, as needed.
            this.offersViewTableAdapter.Fill(this.milk_WholesalerDataSet1.OffersView);

        }
    }
}
