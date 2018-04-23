Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.Drawing




Namespace DevExpress.MyControl
	Public Class MyGridViewInfo
		Inherits GridViewInfo

		Public Sub New(ByVal gridView As GridView)
			MyBase.New(gridView)
			buttonInfo_Renamed = Nothing
		End Sub



'INSTANT VB NOTE: The variable buttonInfo was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private buttonInfo_Renamed As EditorButtonObjectInfoArgs
		Friend ReadOnly Property ButtonInfo() As EditorButtonObjectInfoArgs
			Get
				Return buttonInfo_Renamed
			End Get
		End Property



		Protected Overrides Sub CalcRowsDrawInfo()
			MyBase.CalcRowsDrawInfo()

			CalcButtonInfo()
		End Sub



		Protected Overridable Sub CalcButtonInfo()
			Dim gv As MyGridView = TryCast(View, MyGridView)
			If gv.SaveButton IsNot Nothing Then
				Dim rowsCount As Integer = RowsLoadInfo.ResultRows.Count
				If RowsInfo.Count > 0 AndAlso RowsInfo.Count = rowsCount AndAlso (RowsInfo(RowsInfo.Count - 1).Bounds.Bottom) < ViewRects.Rows.Bottom Then
					Dim gri As GridRowInfo = RowsInfo(RowsInfo.Count - 1)
					If buttonInfo_Renamed Is Nothing Then
						buttonInfo_Renamed = New EditorButtonObjectInfoArgs(gv.SaveButton, gv.SaveButton.Appearance)
					End If
					buttonInfo_Renamed.Bounds = New Rectangle(gri.Bounds.X + 2, gri.Bounds.Bottom + 2, 40, 18)
					Return
				End If
			End If

			buttonInfo_Renamed = Nothing
		End Sub



		Friend Sub UpdateButtonState(ByVal state As ObjectState)
			If buttonInfo_Renamed Is Nothing Then
				Return
			End If
			buttonInfo_Renamed.State = state
		End Sub
	End Class
End Namespace
