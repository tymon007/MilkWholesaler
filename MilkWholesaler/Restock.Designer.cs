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
            this.milk_WholesalerDataSet1 = new MilkWholesaler.Milk_WholesalerDataSet1();
            this.offersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offersViewTableAdapter = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.OffersViewTableAdapter();
            this.tableAdapterManager = new MilkWholesaler.Milk_WholesalerDataSet1TableAdapters.TableAdapterManager();
            this.offersViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.offersViewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.offersViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.milk_WholesalerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingNavigator)).BeginInit();
            this.offersViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // milk_WholesalerDataSet1
            // 
            this.milk_WholesalerDataSet1.DataSetName = "Milk_WholesalerDataSet1";
            this.milk_WholesalerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offersViewBindingSource
            // 
            this.offersViewBindingSource.DataMember = "OffersView";
            this.offersViewBindingSource.DataSource = this.milk_WholesalerDataSet1;
            // 
            // offersViewTableAdapter
            // 
            this.offersViewTableAdapter.ClearBeforeFill = true;
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
            this.offersViewBindingNavigator.Size = new System.Drawing.Size(800, 25);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.offersViewDataGridView.DataSource = this.offersViewBindingSource;
            this.offersViewDataGridView.Location = new System.Drawing.Point(237, 91);
            this.offersViewDataGridView.Name = "offersViewDataGridView";
            this.offersViewDataGridView.Size = new System.Drawing.Size(342, 351);
            this.offersViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn5.HeaderText = "SupplierName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SupplierPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "SupplierPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(39, 91);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(136, 20);
            this.textBox_search.TabIndex = 9;
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.offersViewDataGridView);
            this.Controls.Add(this.offersViewBindingNavigator);
            this.Name = "Restock";
            this.Text = "Restock";
            this.Load += new System.EventHandler(this.Restock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.milk_WholesalerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewBindingNavigator)).EndInit();
            this.offersViewBindingNavigator.ResumeLayout(false);
            this.offersViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offersViewDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox_search;
    }
}