Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms



Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.carsDBDataSet_Renamed.Customers)
			Me.ordersTableAdapter1.Fill(Me.carsDBDataSet_Renamed.Orders)
			myGridControl1.DataSource = carsDBDataSet_Renamed.Tables("Customers")
		End Sub




		Private Sub myGridControl1_SaveButtonClick(ByVal sender As Object, ByVal e As DevExpress.MyControl.MyGridView) Handles myGridControl1.SaveButtonClick
			MessageBox.Show(String.Format("SaveButtonClick at MyGridView with {0} rows", e.RowCount))
		End Sub
	End Class
End Namespace