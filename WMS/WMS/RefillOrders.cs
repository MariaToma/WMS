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
    public partial class RefillOrders : Form
    {
        public RefillOrders()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            { gvRefillOrders.DataSource = (from rd in context.RefillOrders
                                          join rod in context.RefillOrderDetails on rd.OrderID equals rod.OrderID
                                          join p in context.Products on rod.ProductID equals p.ProductID
                                          select new
                                          {
                                              p.ProductName,
                                              rd.OrderSource,
                                              rd.OrderDestination,
                                              rod.Quantity
                                         }
                                        ).Distinct().ToList();
            }
        }

        private void RefillOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string ProductName="";
            string orderSource="";
            string orderDestination="";
            string quantity="";
            try
            {
                if (gvRefillOrders.SelectedCells.Count == 0) throw new Exception("Select an order!");
                if (gvRefillOrders.SelectedCells.Count < 2) throw new Exception("Select the entire row!");

                foreach (DataGridViewRow row in gvRefillOrders.SelectedRows)
                {
                    ProductName = row.Cells[0].Value.ToString();
                    orderSource = row.Cells[1].Value.ToString();
                    orderDestination = row.Cells[2].Value.ToString();
                    quantity= row.Cells[3].Value.ToString();
                }




                Form form = new DetailsForm(ProductName,orderSource,orderDestination,quantity);
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            
        }
    }
}
