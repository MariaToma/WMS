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
    public partial class AfterProductStock : Form
    {
        public AfterProductStock()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            {
                cmbStockP.DataSource = (from p in context.Products
                                        select p.ProductName).Distinct().ToList();
                                  
            }
           

        }

        private void btnStockP_Click(object sender, EventArgs e)
        {
            string ProductName = cmbStockP.SelectedItem.ToString();
            using (var context = new WMSEntities())
            {
                gvStockP.DataSource = (from p in context.Products
                                       where p.ProductName == ProductName
                                       select new
                                       {
                                           WarehouseId = p.WarehouseID,
                                           UnitsInStock=p.UnitsInStock

                                       }
                                       ).ToList();
           }
        }
    }
}
