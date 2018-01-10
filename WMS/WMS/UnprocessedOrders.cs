using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace WMS
{
    public partial class UnprocessedOrders : Form
    {
        public UnprocessedOrders()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                    try
                    {
                        gvUnproccOrders.DataSource = (from c in context.Clients
                                                      join cd in context.ClientOrderDetails on c.ClientID equals cd.ClientID
                                                      where cd.OrderState.Equals("unprocessed")
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
                    catch(Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        MessageBox.Show(ex.Message.ToString());
                    }

            }
        }

        private void txtSelect_TextChanged(object sender, EventArgs e)
        {

        }


        private void TryRefillfromWarehouse(string Product, string Quantity,int DestinationWarehouseID,int OrderID,string ClientName,string Adress)
        {
            using (var context = new WMSEntities())
            {
               
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        int quantity = Int32.Parse(Quantity);
                        var result = (from p in context.Products
                                      where p.ProductName.Equals(Product) && p.UnitsInStock >= quantity
                                      select new
                                      {
                                          SourceWarehouseID = p.WarehouseID,
                                          units = p.UnitsInStock,
                                          prodID = p.ProductID,
                                          rowID = p.RowID,
                                          price = p.UnitPrice
                                      });

                        if (!string.IsNullOrWhiteSpace(result.ToString()))
                        {
                            if (result.Count() != 0)
                            {
                                var rez = result.ToList();

                                DialogResult dr = MessageBox.Show(String.Format("Do you want to refill warehouse {0} from warehouse {1} with product ->{2}, units->{3}?", DestinationWarehouseID, rez[0].SourceWarehouseID, Product, Quantity), "The Question",
                                               MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button1);


                                switch (dr)
                                {
                                    case DialogResult.Yes:
                                        {
                                            int sourceID;
                                            Int32.TryParse(rez[0].SourceWarehouseID.ToString(), out sourceID);
                                            float price = float.Parse(rez[0].price.ToString());
                                            Form refill = new RefillForm(sourceID, DestinationWarehouseID, Product, Quantity,false);
                                            refill.ShowDialog();
                                            context.RefillFromWarehouse(rez[0].SourceWarehouseID, DestinationWarehouseID, quantity, Product);
                                            refill.Close();
                                  //          Form BarCodeCheck = new BarCodeCheck(rez[0].prodID);
                                    //        BarCodeCheck.Show();
                                            MessageBox.Show("The refill is done! Order is ready to be processed! ");
                                            Form fr = new ProcessingOrder(OrderID.ToString(), ClientName, Adress, Product, quantity, rez[0].rowID,price);
                                            fr.Show();
                                            context.UpdateDB(Product, quantity, DestinationWarehouseID);
                                            context.SaveChanges();
                                            context.MarkProcessed(OrderID, rez[0].prodID);

                                            context.SaveChanges();
                                            dbContextTransaction.Commit();

                                            break;
                                        };
                                    case DialogResult.No:
                                        {
                                            break;
                                        };
                                }
                            }
                            else
                            {
                                var rez = (from p in context.Products
                                           where p.ProductName.Equals(Product)
                                           select new
                                           {
                                               prodID = p.ProductID,
                                               rowID = p.RowID,
                                               Price = p.UnitPrice

                                           }).ToList();
                                         
                                Form refill = new RefillForm(0, DestinationWarehouseID, Product, Quantity,false);
                                refill.ShowDialog();
                               // Form BarCodeCheck = new BarCodeCheck(rez[0].prodID);
                                //BarCodeCheck.Show();
                                context.RefillFromWarehouse(0, DestinationWarehouseID, quantity, Product);
                                context.SaveChanges();
                                refill.Close();
                                MessageBox.Show("The refill is done! Order is ready to be processed! ");
                                float price = float.Parse(rez[0].Price.ToString());
                                Form fr = new ProcessingOrder(OrderID.ToString(), ClientName, Adress, Product, quantity, rez[0].rowID,price);
                                fr.Show();
                                context.MarkProcessed(OrderID, rez[0].prodID);
                                context.SaveChanges();
                                context.UpdateDB(Product, quantity, DestinationWarehouseID);
                                context.SaveChanges();
                                dbContextTransaction.Commit();

                            }
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    dbContextTransaction.Rollback();
                }

            }
           }
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
          
            try {
                if (gvUnproccOrders.SelectedCells.Count == 0) throw new Exception("No orders to process!");
                if (gvUnproccOrders.SelectedCells.Count < 2) throw new Exception("Select the entire row!");
                string SearchValue="";
                string OrderID="";
                foreach (DataGridViewRow row in gvUnproccOrders.SelectedRows)
                {
                    OrderID = row.Cells[0].Value.ToString();
                     SearchValue = OrderID;
                }

                int rowIndex = -1;
                foreach (DataGridViewRow row in gvUnproccOrders.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(SearchValue))
                    {
                        rowIndex = row.Index;
                        gvUnproccOrders.Rows[rowIndex].Selected = true;
                        string ClientName = row.Cells[1].Value.ToString();
                        string Adress = row.Cells[2].Value.ToString();
                        string Product = row.Cells[3].Value.ToString();
                        string Quantity = row.Cells[4].Value.ToString();
                        string WarehouseID = row.Cells[5].Value.ToString();
                      
                        using (var context = new WMSEntities())
                        {
                            using (var dbContextTransaction = context.Database.BeginTransaction())
                            {

                                try
                                {
                                    var prodID = (from p in context.Products
                                                  where p.ProductName.Equals(Product)
                                                  select p).First().ProductID;


                                    int warehouseID = Int32.Parse(WarehouseID);
                                    var WarehouseName = (from c in context.Warehouses
                                                         where c.WarehouseID.Equals(warehouseID)
                                                         select c).First().Address;
                                    var check = (from p in context.Products
                                                 where p.ProductName.Equals(Product) && p.WarehouseID.Equals(warehouseID)
                                                 select p).FirstOrDefault();

                                    if (check != null)
                                    {
                                        if (!string.IsNullOrWhiteSpace(check.ToString()))
                                        {
                                            var unitsInStock = (from p in context.Products
                                                                where p.ProductName.Equals(Product) && p.WarehouseID.Equals(warehouseID)
                                                                select p).FirstOrDefault().UnitsInStock;
                                            if (unitsInStock < Int32.Parse(Quantity))
                                            {
                                                MessageBox.Show(String.Format("Unfortunately, warehouse {0} do not have {1} units of {2}. Trying to refill from other warehouses...", WarehouseID, Quantity, Product));
                                                int orderID = Int32.Parse(OrderID);
                                                TryRefillfromWarehouse(Product, Quantity, warehouseID, orderID, ClientName, Adress);
                                            }
                                            else
                                            {
                                                var rez = (from p in context.Products
                                                           where p.ProductName.Equals(Product)
                                                           select new
                                                           {
                                                              
                                                               rowID = p.RowID,
                                                               Price = p.UnitPrice,
                                                               prodID=p.ProductID

                                                           }).ToList();

                                                int quantity = Int32.Parse(Quantity);
                                                float price = float.Parse(rez[0].Price.ToString());
                                                Form processingForm = new ProcessingOrder(OrderID, ClientName, Adress, Product, quantity, rez[0].rowID,price);
                                                processingForm.Show();
                                                int units = Int32.Parse(Quantity);
                                                int orderID = Int32.Parse(OrderID);
                                                context.UpdateDB(Product, units, warehouseID);
                                                context.SaveChanges();
                                                context.MarkProcessed(orderID, prodID);
                                                context.SaveChanges();
                                                dbContextTransaction.Commit();

                                            }
                                        }
                                    }
                                    else
                                    {
                                        int orderID = Int32.Parse(OrderID);
                                        MessageBox.Show(String.Format("Unfortunately, {0} warehouse do not have {1} units of {2}. Trying to refill from other warehouses...", WarehouseName, Quantity, Product));
                                        TryRefillfromWarehouse(Product, Quantity, warehouseID, orderID, ClientName, Adress);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message.ToString());
                                    dbContextTransaction.Rollback();
                                }
                            }
                                  
                        }
                       
                    }
                }
      
                this.Close();
               
            }
           
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvUnproccOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
