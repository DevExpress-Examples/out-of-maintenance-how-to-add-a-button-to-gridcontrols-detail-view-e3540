using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;





namespace DevExpress.MyControl
{
    public class MyGridPainter : GridPainter
    {
        public MyGridPainter(GridView view) 
            : base(view) 
        {
		}



        protected override void DrawRows(GridViewDrawArgs e)
        {            
            base.DrawRows(e);
            DrawButton(e);
        }



        protected virtual void DrawButton(GridViewDrawArgs e)
        {
            EditorButtonObjectInfoArgs info = (e.ViewInfo as MyGridViewInfo).ButtonInfo;
            if (info != null)
            {
                EditorButtonPainter painter = EditorButtonHelper.GetPainter(BorderStyles.Default);
                info.Cache = e.Cache;
                painter.DrawObject(info);
            }
        }
    }
}
