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
    public partial class DetailsForm : Form
    {
        public DetailsForm(string ProductName, string Source, string Destination,string Quantity)
        {
            InitializeComponent();
            int source = Int32.Parse(Source);
            int destination = Int32.Parse(Destination);
            int quantity = Int32.Parse(Quantity);
            using (var context=new WMSEntities())
            {
                string SourceFinal="";
                if (Source == "0") SourceFinal = "Factory";
                else
                {
                    var SourceAdress = (from w in context.Warehouses
                                        where w.WarehouseID == source
                                        select w.Address).First();
                    SourceFinal = SourceAdress.ToString();
                }
              

                var DestinationAdress = (from w in context.Warehouses
                                    where w.WarehouseID == destination
                                    select w.Address).First();

                if (SourceFinal == "Factory")
                {
                    txtDetails.Text = "Refill order from factory to warehouse " + Destination + " at adress " + DestinationAdress.ToString();
                    txtDetails.AppendText(Environment.NewLine);
                    txtDetails.AppendText("Product name--->"+ ProductName);
                    txtDetails.AppendText(Environment.NewLine);
                    txtDetails.AppendText("Quantity of products--->" + Quantity);
                }
                else
                {
                    txtDetails.Text = "Refill order from warehouse "+Source+" at adress " +SourceFinal+" to warehouse " + Destination + " at adress " + DestinationAdress.ToString();
                    txtDetails.AppendText(Environment.NewLine);
                    txtDetails.AppendText("Product name--->" + ProductName);
                    txtDetails.AppendText(Environment.NewLine);
                    txtDetails.AppendText("Quantity of products--->" + Quantity);
                }
            }
            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
