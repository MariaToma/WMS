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
    public partial class ProcessedOrders : Form
    {
        public ProcessedOrders()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                    try
                    {
                        gvProccOrders.DataSource = (from c in context.Clients
                                                      join cd in context.ClientOrderDetails on c.ClientID equals cd.ClientID
                                                      where cd.OrderState.Equals("processed")
                                                      join p in context.Products on cd.ProductID equals p.ProductID

                                                      select new
                                                      {
                                                          cd.OrderID,
                                                          c.Name,
                                                          c.Address,
                                                          p.ProductName,
                                                          cd.Quantity,
                                                          cd.WarehouseID
                                                      }
                                        ).Distinct().ToList();

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        MessageBox.Show(ex.Message.ToString());
                    }

            }
        
    }

        private void gvUnproccOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProcessedOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
