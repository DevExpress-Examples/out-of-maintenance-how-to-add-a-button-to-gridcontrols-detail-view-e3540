using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.carsDBDataSet.Customers);
            this.ordersTableAdapter1.Fill(this.carsDBDataSet.Orders);
            myGridControl1.DataSource = carsDBDataSet.Tables["Customers"];
        }




        private void myGridControl1_SaveButtonClick(object sender, DevExpress.MyControl.MyGridView e)
        {
            MessageBox.Show(string.Format("SaveButtonClick at MyGridView with {0} rows", e.RowCount));
        }
    }
}