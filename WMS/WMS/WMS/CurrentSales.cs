using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;

namespace WMS
{
    public partial class CurrentSales : Form
    {
        public CurrentSales()
        {
            InitializeComponent();
            var context = new WMSEntities();
            txtCurrentSales.Text = "Please select a Warehouse";
            var result = (from c in context.Warehouses
                          select c.Address
                                             ).ToList();

            warehousesComboBox.DataSource = (from c in context.Warehouses
                                             select c.WarehouseID
                                             ).ToList();
            



           // warehousesComboBox.ValueMember=Warehouse
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCurrentSales_Click(object sender, EventArgs e)
        {
            using (var contex = new WMSEntities())
            {
                int WarehouseID = Int32.Parse(warehousesComboBox.SelectedItem.ToString());
                gvCurrentSales.DataSource = (from c in contex.CurrentSales
                                             where c.WarehouseID==WarehouseID 
                                             select new
                                             {
                                                 Order = c.OrderID,
                                                 Price = c.TotalPrice
                                             }).ToList();

                
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            //int WarehouseID = Int32.Parse(warehousesComboBox.SelectedItem.ToString());
            //ReportDocument rd = new ReportDocument();
            //rd.Load("E:\\WMS\\WMS\\WMS\\CrystalReport.rpt");
            //rd.SetDataSource(gvCurrentSales);
            //if (File.Exists(@"E:\" + WarehouseID + ".pdf"))
            //    File.Delete(@"E:\" + WarehouseID + ".pdf");
            //rd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"E:\" + WarehouseID + ".pdf");


          
        }
    }
}
