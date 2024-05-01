namespace MilkWholesaler
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            this.button_select = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_select
            // 
            this.button_select.BackgroundImage = global::MilkWholesaler.Properties.Resources.select;
            this.button_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select.Location = new System.Drawing.Point(123, 266);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(40, 40);
            this.button_select.TabIndex = 3;
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // button_filter
            // 
            this.button_filter.BackgroundImage = global::MilkWholesaler.Properties.Resources.filter;
            this.button_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_filter.Location = new System.Drawing.Point(123, 199);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(40, 40);
            this.button_filter.TabIndex = 2;
            this.button_filter.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = global::MilkWholesaler.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_search.Location = new System.Drawing.Point(123, 132);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(40, 40);
            this.button_search.TabIndex = 1;
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_return
            // 
            this.button_return.BackgroundImage = global::MilkWholesaler.Properties.Resources._return;
            this.button_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_return.Location = new System.Drawing.Point(748, 12);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(40, 40);
            this.button_return.TabIndex = 0;
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 213);
            this.dataGridView1.TabIndex = 4;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_return);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}