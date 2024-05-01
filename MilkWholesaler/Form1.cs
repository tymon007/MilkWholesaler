namespace MilkWholesaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            Form inventory = new Inventory(this);
            inventory.Show();
            this.Hide();
        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            Form orders = new Orders(this);
            orders.Show();
            this.Hide();
        }
    }
}
