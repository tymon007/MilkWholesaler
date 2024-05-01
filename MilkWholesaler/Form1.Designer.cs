namespace MilkWholesaler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_inventory = new Button();
            button_orders = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_inventory
            // 
            button_inventory.BackgroundImage = Properties.Resources.inventory;
            button_inventory.BackgroundImageLayout = ImageLayout.Stretch;
            button_inventory.Location = new Point(69, 199);
            button_inventory.Name = "button_inventory";
            button_inventory.Size = new Size(150, 150);
            button_inventory.TabIndex = 0;
            button_inventory.UseVisualStyleBackColor = true;
            button_inventory.Click += button_inventory_Click;
            // 
            // button_orders
            // 
            button_orders.BackgroundImage = Properties.Resources.orders1;
            button_orders.BackgroundImageLayout = ImageLayout.Stretch;
            button_orders.Location = new Point(380, 199);
            button_orders.Name = "button_orders";
            button_orders.Size = new Size(150, 150);
            button_orders.TabIndex = 2;
            button_orders.UseVisualStyleBackColor = true;
            button_orders.Click += button_orders_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.milkman_wms;
            pictureBox1.Location = new Point(184, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.milkbckg;
            ClientSize = new Size(606, 407);
            Controls.Add(pictureBox1);
            Controls.Add(button_orders);
            Controls.Add(button_inventory);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_inventory;
        private Button button_orders;
        private PictureBox pictureBox1;
    }
}
