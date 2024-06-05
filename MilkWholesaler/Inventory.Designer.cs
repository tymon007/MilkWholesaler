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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.inventoryViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inventoryViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inventoryViewDataGridView = new System.Windows.Forms.DataGridView();
            this.button_restock = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milk_WholesalerDataSet1 = new MilkWholesaler.Milk_WholesalerDataSet1();
            this.inventoryViewTableAdapter = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.InventoryViewTableAdapter();
            this.tableAdapterManager = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryViewBindingNavigator)).BeginInit();
            this.inventoryViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk_WholesalerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryViewBindingNavigator
            // 
            this.inventoryViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inventoryViewBindingNavigator.BindingSource = this.inventoryViewBindingSource;
            this.inventoryViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inventoryViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inventoryViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inventoryViewBindingNavigatorSaveItem});
            this.inventoryViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inventoryViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inventoryViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inventoryViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inventoryViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inventoryViewBindingNavigator.Name = "inventoryViewBindingNavigator";
            this.inventoryViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inventoryViewBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.inventoryViewBindingNavigator.TabIndex = 4;
            this.inventoryViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // inventoryViewBindingNavigatorSaveItem
            // 
            this.inventoryViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inventoryViewBindingNavigatorSaveItem.Enabled = false;
            this.inventoryViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inventoryViewBindingNavigatorSaveItem.Image")));
            this.inventoryViewBindingNavigatorSaveItem.Name = "inventoryViewBindingNavigatorSaveItem";
            this.inventoryViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.inventoryViewBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // inventoryViewDataGridView
            // 
            this.inventoryViewDataGridView.AutoGenerateColumns = false;
            this.inventoryViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.inventoryViewDataGridView.DataSource = this.inventoryViewBindingSource;
            this.inventoryViewDataGridView.Location = new System.Drawing.Point(126, 177);
            this.inventoryViewDataGridView.Name = "inventoryViewDataGridView";
            this.inventoryViewDataGridView.Size = new System.Drawing.Size(643, 220);
            this.inventoryViewDataGridView.TabIndex = 5;
            // 
            // button_restock
            // 
            this.button_restock.BackgroundImage = global::MilkWholesaler.Properties.Resources.restock;
            this.button_restock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_restock.Location = new System.Drawing.Point(47, 382);
            this.button_restock.Name = "button_restock";
            this.button_restock.Size = new System.Drawing.Size(40, 40);
            this.button_restock.TabIndex = 6;
            this.button_restock.UseVisualStyleBackColor = true;
            // 
            // button_select
            // 
            this.button_select.BackgroundImage = global::MilkWholesaler.Properties.Resources.select;
            this.button_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select.Location = new System.Drawing.Point(47, 304);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(40, 40);
            this.button_select.TabIndex = 3;
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // button_filter
            // 
            this.button_filter.BackgroundImage = global::MilkWholesaler.Properties.Resources.filter;
            this.button_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_filter.Location = new System.Drawing.Point(47, 199);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(40, 40);
            this.button_filter.TabIndex = 2;
            this.button_filter.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = global::MilkWholesaler.Properties.Resources.search;
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_search.Location = new System.Drawing.Point(47, 245);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(40, 40);
            this.button_search.TabIndex = 1;
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_return
            // 
            this.button_return.BackgroundImage = global::MilkWholesaler.Properties.Resources._return;
            this.button_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_return.Location = new System.Drawing.Point(763, 38);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(40, 40);
            this.button_return.TabIndex = 0;
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QuantityOnHand";
            this.dataGridViewTextBoxColumn2.HeaderText = "QuantityOnHand";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ExpirationDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "ExpirationDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WarehouseLocation";
            this.dataGridViewTextBoxColumn4.HeaderText = "WarehouseLocation";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // inventoryViewBindingSource
            // 
            this.inventoryViewBindingSource.DataMember = "InventoryView";
            this.inventoryViewBindingSource.DataSource = this.milk_WholesalerDataSet1;
            // 
            // milk_WholesalerDataSet1
            // 
            this.milk_WholesalerDataSet1.DataSetName = "Milk_WholesalerDataSet1";
            this.milk_WholesalerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryViewTableAdapter
            // 
            this.inventoryViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.OffersTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.OrdersViewTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SalesDetailsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.SalesViewTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 591);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_restock);
            this.Controls.Add(this.inventoryViewDataGridView);
            this.Controls.Add(this.inventoryViewBindingNavigator);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_return);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryViewBindingNavigator)).EndInit();
            this.inventoryViewBindingNavigator.ResumeLayout(false);
            this.inventoryViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk_WholesalerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_select;
        private Milk_WholesalerDataSet1 milk_WholesalerDataSet1;
        private System.Windows.Forms.BindingSource inventoryViewBindingSource;
        private Milk_WholesalerDataSet1TableAdapters.InventoryViewTableAdapter inventoryViewTableAdapter;
        private Milk_WholesalerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inventoryViewBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inventoryViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView inventoryViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_restock;
        private System.Windows.Forms.TextBox textBox1;
    }
}