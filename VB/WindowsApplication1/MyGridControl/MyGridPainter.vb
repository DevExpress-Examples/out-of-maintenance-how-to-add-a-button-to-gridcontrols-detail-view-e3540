Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Drawing





Namespace DevExpress.MyControl
	Public Class MyGridPainter
		Inherits GridPainter

		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
		End Sub



		Protected Overrides Sub DrawRows(ByVal e As GridViewDrawArgs)
			MyBase.DrawRows(e)
			DrawButton(e)
		End Sub



		Protected Overridable Sub DrawButton(ByVal e As GridViewDrawArgs)
			Dim info As EditorButtonObjectInfoArgs = (TryCast(e.ViewInfo, MyGridViewInfo)).ButtonInfo
			If info IsNot Nothing Then
				Dim painter As EditorButtonPainter = EditorButtonHelper.GetPainter(BorderStyles.Default)
				info.Cache = e.Cache
				painter.DrawObject(info)
			End If
		End Sub
	End Class
End Namespace
