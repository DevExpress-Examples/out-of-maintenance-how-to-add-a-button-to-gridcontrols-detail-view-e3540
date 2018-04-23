Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid





Namespace DevExpress.MyControl
	Public Class MyGridView
		Inherits GridView

'INSTANT VB NOTE: The variable TOOLBARHeight was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private Const TOOLBARHeight_Renamed As Integer = 24
		Private buttonIsHot As Boolean



'INSTANT VB NOTE: The variable saveButton was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private saveButton_Renamed As EditorButton
		Friend ReadOnly Property SaveButton() As EditorButton
			Get
				Return saveButton_Renamed
			End Get
		End Property



        Private mouseMoveHandler As MouseEventHandler



        Friend ReadOnly Property ToolBarHeight() As Integer
			Get
				Return (If(ButtonSaveRequired(), TOOLBARHeight_Renamed, 0))
			End Get
		End Property



		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property



		Public Sub New()
			Me.New(Nothing)
		End Sub




		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
			saveButton_Renamed = Nothing
            mouseMoveHandler = New MouseEventHandler(AddressOf MyOnMouseMove)
            AddHandler MouseMove, mouseMoveHandler
            buttonIsHot = False
		End Sub




		Protected Overridable Sub MyOnMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If IsDetailView AndAlso HitMouseSaveButton(e.Location) Then
				If Not buttonIsHot Then
					TryCast(ViewInfo, MyGridViewInfo).UpdateButtonState(DevExpress.Utils.Drawing.ObjectState.Hot)
					If (TryCast(ViewInfo, MyGridViewInfo)).ButtonInfo IsNot Nothing Then
						GridControl.Invalidate((TryCast(ViewInfo, MyGridViewInfo)).ButtonInfo.Bounds)
					End If
					buttonIsHot = True
				End If


			Else
				If buttonIsHot Then
					TryCast(ViewInfo, MyGridViewInfo).UpdateButtonState(DevExpress.Utils.Drawing.ObjectState.Normal)
					If (TryCast(ViewInfo, MyGridViewInfo)).ButtonInfo IsNot Nothing Then
						GridControl.Invalidate((TryCast(ViewInfo, MyGridViewInfo)).ButtonInfo.Bounds)
					End If
					buttonIsHot = False
				End If
			End If
		End Sub



		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
                If mouseMoveHandler IsNot Nothing Then
                    RemoveHandler MouseMove, mouseMoveHandler
                    mouseMoveHandler = Nothing
                End If
            End If

			MyBase.Dispose(disposing)
		End Sub



		Protected Overrides Function CalcRealViewHeight(ByVal viewRect As System.Drawing.Rectangle, Optional ByVal reduceHeightOnly As Boolean = True) As Integer
			Dim result As Integer = MyBase.CalcRealViewHeight(viewRect, reduceHeightOnly)
			If ButtonSaveRequired() Then
				result += ToolBarHeight
			End If

			Return result
		End Function



		Private Function ButtonSaveRequired() As Boolean
			Dim result As Boolean = False
			If IsDetailView Then
				If saveButton_Renamed Is Nothing Then
					saveButton_Renamed = New EditorButton(ButtonPredefines.Glyph)
					saveButton_Renamed.Caption = "Save"
				End If
				result = True
			End If

			Return result
		End Function




		Friend Function IsSaveButtonHit(ByVal ev As MouseEventArgs, ByRef gridView As MyGridView) As Boolean
			gridView = Nothing
			Dim result As Boolean = False
			If IsDetailView Then
				If HitMouseSaveButton(ev.Location) Then
					gridView = Me
					result = True
				End If
			End If

			Return result
		End Function



		Private Function HitMouseSaveButton(ByVal location As Point) As Boolean
			If ((TryCast(ViewInfo, MyGridViewInfo)).ButtonInfo Is Nothing) Then
				Return False
			End If
			Return ((TryCast(ViewInfo, MyGridViewInfo)).ButtonInfo.Bounds.Contains(location))
		End Function
	End Class
End Namespace
