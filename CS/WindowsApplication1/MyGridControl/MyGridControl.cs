using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;




namespace DevExpress.MyControl
{
    public delegate void SaveButtonHandler(object sender, MyGridView e); 


    public class MyGridControl : GridControl
    {
		private static readonly object saveButtonClick = new object();


        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
        }


        [Description("Fires when save button was clicked.")]
        public event SaveButtonHandler SaveButtonClick 
        {
            add { Events.AddHandler(saveButtonClick, value); }
            remove { Events.RemoveHandler(saveButtonClick, value); }
		}


        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }



        protected override void OnMouseDown(MouseEventArgs ev)
        {
            base.OnMouseDown(ev);

            BaseView gv = GetViewAt(ev.Location);
            if (gv != null)
            {
                MyGridView gView = null;
                if ((gv as MyGridView).IsSaveButtonHit(ev, out gView))
                    RaiseSaveButtonClick(gView);
            }
        }



        protected virtual void RaiseSaveButtonClick(MyGridView gv)
        {
            SaveButtonHandler handler = Events[saveButtonClick] as SaveButtonHandler;
            if (handler != null) handler(this, gv);
        }
    }
}
