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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button_inventory
            // 
            button_inventory.BackgroundImage = Properties.Resources.inventory;
            button_inventory.BackgroundImageLayout = ImageLayout.Stretch;
            button_inventory.Location = new Point(223, 125);
            button_inventory.Name = "button_inventory";
            button_inventory.Size = new Size(150, 150);
            button_inventory.TabIndex = 0;
            button_inventory.UseVisualStyleBackColor = true;
            button_inventory.Click += button_inventory_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.inventory;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(21, 125);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.inventory;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(426, 125);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.milkbckg;
            ClientSize = new Size(606, 407);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button_inventory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_inventory;
        private Button button1;
        private Button button2;
    }
}
