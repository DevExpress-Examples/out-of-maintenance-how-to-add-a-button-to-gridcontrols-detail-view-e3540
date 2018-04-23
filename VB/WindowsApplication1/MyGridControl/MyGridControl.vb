Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator




Namespace DevExpress.MyControl
	Public Delegate Sub SaveButtonHandler(ByVal sender As Object, ByVal e As MyGridView)


	Public Class MyGridControl
		Inherits GridControl
        Private Shared ReadOnly _saveButtonClick As Object = New Object()


		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function


		<Description("Fires when save button was clicked.")> _
		Public Custom Event SaveButtonClick As SaveButtonHandler
			AddHandler(ByVal value As SaveButtonHandler)
                Events.AddHandler(_saveButtonClick, value)
			End AddHandler
			RemoveHandler(ByVal value As SaveButtonHandler)
                Events.RemoveHandler(_saveButtonClick, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As MyGridView)
			End RaiseEvent
		End Event


		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub



		Protected Overrides Sub OnMouseDown(ByVal ev As MouseEventArgs)
			MyBase.OnMouseDown(ev)

            Dim gv As BaseView = GetViewAt(ev.Location)
            If TypeOf gv Is MyGridView Then
                Dim gView As MyGridView = Nothing
                If (TryCast(gv, MyGridView)).IsSaveButtonHit(ev, gView) Then
                    RaiseSaveButtonClick(gView)
                End If
            End If
		End Sub



		Protected Overridable Sub RaiseSaveButtonClick(ByVal gv As MyGridView)
            Dim handler As SaveButtonHandler = TryCast(Events(_saveButtonClick), SaveButtonHandler)
			If handler IsNot Nothing Then
				handler(Me, gv)
			End If
		End Sub
	End Class
End Namespace
