namespace MilkWholesaler
{
    partial class Restock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restock));
            this.offersViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.offersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milk_WholesalerDataSet1 = new MilkWholesaler.Milk_WholesalerDataSet1();
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
            this.offersViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.offersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_complete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_supplier = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.TableAdapterManager();
            this.offersViewTableAdapter = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.OffersViewTableAdapter();
            this.ordersTableAdapter1 = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.OrdersTableAdapter();
            this.orderDetailsTableAdapter1 = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.OrderDetailsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingNavigator)).BeginInit();
            this.offersViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk_WholesalerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // offersViewBindingNavigator
            // 
            this.offersViewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.offersViewBindingNavigator.BindingSource = this.offersViewBindingSource;
            this.offersViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.offersViewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.offersViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.offersViewBindingNavigatorSaveItem});
            this.offersViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.offersViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.offersViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.offersViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.offersViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.offersViewBindingNavigator.Name = "offersViewBindingNavigator";
            this.offersViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.offersViewBindingNavigator.Size = new System.Drawing.Size(674, 25);
            this.offersViewBindingNavigator.TabIndex = 0;
            this.offersViewBindingNavigator.Text = "bindingNavigator1";
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
            // offersViewBindingSource
            // 
            this.offersViewBindingSource.DataMember = "OffersView";
            this.offersViewBindingSource.DataSource = this.milk_WholesalerDataSet1;
            // 
            // milk_WholesalerDataSet1
            // 
            this.milk_WholesalerDataSet1.DataSetName = "Milk_WholesalerDataSet1";
            this.milk_WholesalerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // offersViewBindingNavigatorSaveItem
            // 
            this.offersViewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.offersViewBindingNavigatorSaveItem.Enabled = false;
            this.offersViewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("offersViewBindingNavigatorSaveItem.Image")));
            this.offersViewBindingNavigatorSaveItem.Name = "offersViewBindingNavigatorSaveItem";
            this.offersViewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.offersViewBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // offersViewDataGridView
            // 
            this.offersViewDataGridView.AutoGenerateColumns = false;
            this.offersViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offersViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.OfferID,
            this.ProductID,
            this.SupplierID,
            this.Supplier,
            this.Price});
            this.offersViewDataGridView.DataSource = this.offersViewBindingSource;
            this.offersViewDataGridView.Location = new System.Drawing.Point(255, 87);
            this.offersViewDataGridView.Name = "offersViewDataGridView";
            this.offersViewDataGridView.Size = new System.Drawing.Size(343, 351);
            this.offersViewDataGridView.TabIndex = 1;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "ProductName";
            this.Product.HeaderText = "ProductName";
            this.Product.Name = "Product";
            // 
            // OfferID
            // 
            this.OfferID.DataPropertyName = "OfferID";
            this.OfferID.HeaderText = "Column1";
            this.OfferID.Name = "OfferID";
            this.OfferID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "SupplierID";
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Visible = false;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "SupplierName";
            this.Supplier.HeaderText = "SupplierName";
            this.Supplier.Name = "Supplier";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "SupplierPrice";
            this.Price.HeaderText = "SupplierPrice";
            this.Price.Name = "Price";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(255, 58);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(136, 20);
            this.textBox_search.TabIndex = 9;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(52, 77);
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_quantity.TabIndex = 10;
            this.numericUpDown_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 190);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(215, 154);
            this.checkedListBox1.TabIndex = 13;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // button_complete
            // 
            this.button_complete.BackgroundImage = global::MilkWholesaler.Properties.Resources.order;
            this.button_complete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_complete.Location = new System.Drawing.Point(80, 378);
            this.button_complete.Name = "button_complete";
            this.button_complete.Size = new System.Drawing.Size(60, 60);
            this.button_complete.TabIndex = 14;
            this.button_complete.UseVisualStyleBackColor = true;
            this.button_complete.Click += new System.EventHandler(this.button_complete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirm order:";
            // 
            // button_select
            // 
            this.button_select.BackgroundImage = global::MilkWholesaler.Properties.Resources.select;
            this.button_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_select.Location = new System.Drawing.Point(89, 127);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(40, 40);
            this.button_select.TabIndex = 16;
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Add selected item to order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Supplier:";
            // 
            // textBox_supplier
            // 
            this.textBox_supplier.Location = new System.Drawing.Point(462, 54);
            this.textBox_supplier.Name = "textBox_supplier";
            this.textBox_supplier.Size = new System.Drawing.Size(136, 20);
            this.textBox_supplier.TabIndex = 18;
            this.textBox_supplier.TextChanged += new System.EventHandler(this.textBox_supplier_TextChanged);
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
            // offersViewTableAdapter
            // 
            this.offersViewTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // orderDetailsTableAdapter1
            // 
            this.orderDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Check an item to delete it:";
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_supplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_complete);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.offersViewDataGridView);
            this.Controls.Add(this.offersViewBindingNavigator);
            this.Name = "Restock";
            this.Text = "Restock";
            this.Load += new System.EventHandler(this.Restock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingNavigator)).EndInit();
            this.offersViewBindingNavigator.ResumeLayout(false);
            this.offersViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milk_WholesalerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Milk_WholesalerDataSet1 milk_WholesalerDataSet1;
        private System.Windows.Forms.BindingSource offersViewBindingSource;
        private Milk_WholesalerDataSet1TableAdapters.OffersViewTableAdapter offersViewTableAdapter;
        private Milk_WholesalerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator offersViewBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton offersViewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView offersViewDataGridView;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button_complete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_supplier;
        private Milk_WholesalerDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private Milk_WholesalerDataSet1TableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter1;
        private System.Windows.Forms.Label label6;
    }
}