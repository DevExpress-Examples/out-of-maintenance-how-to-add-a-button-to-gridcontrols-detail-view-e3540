Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet_Renamed = New WindowsApplication1.CarsDBDataSet()
			Me.customersTableAdapter = New WindowsApplication1.CarsDBDataSetTableAdapters.CustomersTableAdapter()
			Me.ordersTableAdapter1 = New WindowsApplication1.CarsDBDataSetTableAdapters.OrdersTableAdapter()
			Me.myGridControl1 = New DevExpress.MyControl.MyGridControl()
			Me.myGridView1 = New DevExpress.MyControl.MyGridView()
			Me.colCustomerID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			DirectCast(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.carsDBDataSet_Renamed
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' ordersTableAdapter1
			' 
			Me.ordersTableAdapter1.ClearBeforeFill = True
			' 
			' myGridControl1
			' 
			Me.myGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			gridLevelNode1.RelationName = "Customers_Orders"
			Me.myGridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.myGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(656, 371)
			Me.myGridControl1.TabIndex = 1
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1})
'			Me.myGridControl1.SaveButtonClick += New DevExpress.MyControl.SaveButtonHandler(Me.myGridControl1_SaveButtonClick)
			' 
			' myGridView1
			' 
			Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID1, Me.colCompanyName1})
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
			' 
			' colCustomerID1
			' 
			Me.colCustomerID1.FieldName = "CustomerID"
			Me.colCustomerID1.Name = "colCustomerID1"
			Me.colCustomerID1.Visible = True
			Me.colCustomerID1.VisibleIndex = 0
			' 
			' colCompanyName1
			' 
			Me.colCompanyName1.FieldName = "CompanyName"
			Me.colCompanyName1.Name = "colCompanyName1"
			Me.colCompanyName1.Visible = True
			Me.colCompanyName1.VisibleIndex = 1
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(680, 395)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

'INSTANT VB NOTE: The variable carsDBDataSet was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private carsDBDataSet_Renamed As CarsDBDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As WindowsApplication1.CarsDBDataSetTableAdapters.CustomersTableAdapter
		Private ordersTableAdapter1 As WindowsApplication1.CarsDBDataSetTableAdapters.OrdersTableAdapter
		Private WithEvents myGridControl1 As DevExpress.MyControl.MyGridControl
		Private myGridView1 As DevExpress.MyControl.MyGridView
		Private colCustomerID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName1 As DevExpress.XtraGrid.Columns.GridColumn
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace

