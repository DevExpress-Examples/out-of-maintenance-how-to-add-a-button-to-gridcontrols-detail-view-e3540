namespace WindowsApplication1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new WindowsApplication1.CarsDBDataSet();
            this.customersTableAdapter = new WindowsApplication1.CarsDBDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new WindowsApplication1.CarsDBDataSetTableAdapters.OrdersTableAdapter();
            this.myGridControl1 = new DevExpress.MyControl.MyGridControl();
            this.myGridView1 = new DevExpress.MyControl.MyGridView();
            this.colCustomerID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // myGridControl1
            // 
            this.myGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Customers_Orders";
            this.myGridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.myGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(656, 371);
            this.myGridControl1.TabIndex = 1;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            this.myGridControl1.SaveButtonClick += new DevExpress.MyControl.SaveButtonHandler(this.myGridControl1_SaveButtonClick);
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID1,
            this.colCompanyName1});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            // 
            // colCustomerID1
            // 
            this.colCustomerID1.FieldName = "CustomerID";
            this.colCustomerID1.Name = "colCustomerID1";
            this.colCustomerID1.Visible = true;
            this.colCustomerID1.VisibleIndex = 0;
            // 
            // colCompanyName1
            // 
            this.colCompanyName1.FieldName = "CompanyName";
            this.colCompanyName1.Name = "colCompanyName1";
            this.colCompanyName1.Visible = true;
            this.colCompanyName1.VisibleIndex = 1;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 395);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private WindowsApplication1.CarsDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private WindowsApplication1.CarsDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private DevExpress.MyControl.MyGridControl myGridControl1;
        private DevExpress.MyControl.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

