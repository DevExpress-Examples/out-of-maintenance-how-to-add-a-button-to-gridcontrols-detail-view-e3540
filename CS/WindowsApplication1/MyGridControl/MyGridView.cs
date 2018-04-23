using System;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;





namespace DevExpress.MyControl
{
    public class MyGridView : GridView
    {
        const int TOOLBARHeight = 24;
        private bool buttonIsHot;



        private EditorButton saveButton;
        internal EditorButton SaveButton
        {
            get
            {
                return saveButton;
            }
        }



        private MouseEventHandler mouseMove;



        internal int ToolBarHeight
        {
            get
            {
                return (ButtonSaveRequired() ? TOOLBARHeight : 0);
            }
        }



        protected override string ViewName
        {
            get { return "MyGridView"; }
        }



        public MyGridView()
            : this(null)
        {
        }




        public MyGridView(GridControl grid)
            : base(grid)
        {
            saveButton = null;
            mouseMove = new MouseEventHandler(MyOnMouseMove);
            MouseMove += mouseMove;
            buttonIsHot = false;
        }




        protected virtual void MyOnMouseMove(object sender, MouseEventArgs e)
        {
            if (IsDetailView && HitMouseSaveButton(e.Location))
            {
                if (!buttonIsHot)
                {
                    (ViewInfo as MyGridViewInfo).UpdateButtonState(DevExpress.Utils.Drawing.ObjectState.Hot);
                    if ((ViewInfo as MyGridViewInfo).ButtonInfo != null) GridControl.Invalidate((ViewInfo as MyGridViewInfo).ButtonInfo.Bounds);
                    buttonIsHot = true;
                }


            }
            else
            {
                if (buttonIsHot)
                {
                    (ViewInfo as MyGridViewInfo).UpdateButtonState(DevExpress.Utils.Drawing.ObjectState.Normal);
                    if ((ViewInfo as MyGridViewInfo).ButtonInfo != null) GridControl.Invalidate((ViewInfo as MyGridViewInfo).ButtonInfo.Bounds);
                    buttonIsHot = false;
                }
            }
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (mouseMove != null)
                {
                    MouseMove -= mouseMove;
                    mouseMove = null;
                }
            }

            base.Dispose(disposing);
        }



        protected override int CalcRealViewHeight(System.Drawing.Rectangle viewRect)
        {
            int result = base.CalcRealViewHeight(viewRect);
            if (ButtonSaveRequired()) result += ToolBarHeight;

            return result;
        }



        private bool ButtonSaveRequired()
        {
            bool result = false;
            if (IsDetailView)
            {
                if (saveButton == null)
                {
                    saveButton = new EditorButton(ButtonPredefines.Glyph);
                    saveButton.Caption = "Save";
                }
                result = true;
            }

            return result;
        }



       
        internal bool IsSaveButtonHit(MouseEventArgs ev, out MyGridView gridView)
        {
            gridView = null;
            bool result = false;
            if (IsDetailView)
            {
                if (HitMouseSaveButton(ev.Location))
                {
                    gridView = this;
                    result = true;
                }
            }

            return result;
        }



        private bool HitMouseSaveButton(Point location)
        {
            if (((ViewInfo as MyGridViewInfo).ButtonInfo == null)) return false;
            return ((ViewInfo as MyGridViewInfo).ButtonInfo.Bounds.Contains(location));
        }    
    }
}
