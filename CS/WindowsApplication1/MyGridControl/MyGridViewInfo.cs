using System.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Drawing;




namespace DevExpress.MyControl
{
    public class MyGridViewInfo : GridViewInfo
    {
        public MyGridViewInfo(GridView gridView)
            : base(gridView)
        {
            buttonInfo = null;
        }



        private EditorButtonObjectInfoArgs buttonInfo;
        internal EditorButtonObjectInfoArgs ButtonInfo
        {
            get
            {
                return buttonInfo;
            }
        }



        protected override void CalcRowsDrawInfo()
        {
            base.CalcRowsDrawInfo();

            CalcButtonInfo();
        }



        protected virtual void CalcButtonInfo()
        {
            MyGridView gv = View as MyGridView;
            if (gv.SaveButton != null)
            {
                int rowsCount = RowsLoadInfo.ResultRows.Count;
                if (RowsInfo.Count > 0 && RowsInfo.Count == rowsCount &&
                    (RowsInfo[RowsInfo.Count - 1].Bounds.Bottom) < ViewRects.Rows.Bottom)
                {
                    GridRowInfo gri = RowsInfo[RowsInfo.Count - 1];
                    if (buttonInfo == null) buttonInfo = new EditorButtonObjectInfoArgs(gv.SaveButton, gv.SaveButton.Appearance);
                    buttonInfo.Bounds = new Rectangle(gri.Bounds.X + 2, gri.Bounds.Bottom + 2, 40, 18);
                    return;
                }
            }

            buttonInfo = null;             
        }



        internal void UpdateButtonState(ObjectState state)
        {
            if (buttonInfo == null) return;
            buttonInfo.State = state;
        }
    }
}
