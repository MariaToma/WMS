using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class ProcessingOrder : Form 
    {
        string OrderID;
        string ClientName;
        string Adress;
        string Products;
        public ProcessingOrder(string a,string b, string c,string d,int quantity,int rowID,float price)
        {
            InitializeComponent();
            this.OrderID = a;
            this.ClientName = b;
            this.Adress = c;
            this.Products = d;
            float total = price * quantity;
            txtProcessing.Multiline = true;
            txtProcessing.ScrollBars = ScrollBars.Horizontal;
            txtProcessing.AcceptsTab = true;
            txtProcessing.WordWrap = false;
            txtProcessing.Text = String.Format("Processing order {0} to client {1}", OrderID, ClientName).ToString();
            txtProcessing.AppendText(Environment.NewLine);
            txtProcessing.AppendText(String.Format("adress {0}, Products-> {1}...", Adress, Products));
            txtProcessing.AppendText(Environment.NewLine);
            txtProcessing.AppendText(String.Format("Total sum={0}", total));
            Form Picking = new PickingForm(Products, rowID, quantity);
            Picking.ShowDialog();
           



            txtProcessing.Font = new Font(txtProcessing.Font.FontFamily, 16);
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
                btnOK.Focus();
                //this.Close();
            }
            if(progressBar1.Value== 100000)
            txtDone.Text = "Order processed";
           
          
           
        }
        
        private void txtProcessing_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
