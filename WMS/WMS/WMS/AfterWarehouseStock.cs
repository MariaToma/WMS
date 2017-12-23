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
    public partial class AfterWarehouseStock : Form
    {
        public AfterWarehouseStock()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            {
                cmbStockW.DataSource = (from w in context.Warehouses
                                        select w.WarehouseID).Distinct().ToList();
            }
        }

        private void btnStockW_Click(object sender, EventArgs e)
        {
            int warehouseID = Int32.Parse(cmbStockW.SelectedItem.ToString());
            using (var context = new WMSEntities())
            {
                gvStockW.DataSource = (from p in context.Products
                                       where p.WarehouseID == warehouseID
                                       select new
                                       {
                                           ProductName = p.ProductName,
                                           UnitsInStock=p.UnitsInStock
                                            
                                       }
                                     ).Distinct().ToList();
            }
        }
    }
}
