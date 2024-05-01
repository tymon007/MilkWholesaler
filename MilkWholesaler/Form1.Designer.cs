namespace MilkWholesaler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_inventory
            // 
            this.button_inventory.BackgroundImage = global::MilkWholesaler.Properties.Resources.inventory;
            this.button_inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_inventory.Location = new System.Drawing.Point(99, 196);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(150, 150);
            this.button_inventory.TabIndex = 0;
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // button_orders
            // 
            this.button_orders.BackgroundImage = global::MilkWholesaler.Properties.Resources.orders1;
            this.button_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_orders.Location = new System.Drawing.Point(351, 196);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(150, 150);
            this.button_orders.TabIndex = 1;
            this.button_orders.UseVisualStyleBackColor = true;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilkWholesaler.Properties.Resources.milkman_wms;
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MilkWholesaler.Properties.Resources.milkbckg;
            this.ClientSize = new System.Drawing.Size(609, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_inventory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

