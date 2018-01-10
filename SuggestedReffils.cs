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
    public partial class SuggestedReffils : Form
    {
        public SuggestedReffils()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                    try
                    {
                        gvSuggestedReffils.DataSource = (from c in context.SuggestedRefillOrders
                                                         from p in context.Products
                                                         from w in context.Warehouses
                                                         where w.WarehouseID==c.WarehouseID
                                                         where p.ProductID==c.ProductID

                                                         select new
                                                         {
                                                             c.SuggestedOrderID,
                                                             //p.ProductID,
                                                             p.ProductName,
                                                             w.WarehouseID,
                                                             w.Address
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
      
        private void SuggestedReffils_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceptSuggestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvSuggestedReffils.SelectedCells.Count == 0) throw new Exception("No suggestions!");
                if (gvSuggestedReffils.SelectedCells.Count < 2) throw new Exception("Select the entire row!");
                string SearchValue = "";
                string SuggestedOrderID = "";
                foreach (DataGridViewRow row in gvSuggestedReffils.SelectedRows)
                {
                    SuggestedOrderID = row.Cells[0].Value.ToString();
                    SearchValue = SuggestedOrderID;
                }

                int rowIndex = -1;
                foreach (DataGridViewRow row in gvSuggestedReffils.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(SearchValue))
                    {
                        rowIndex = row.Index;
                        gvSuggestedReffils.Rows[rowIndex].Selected = true;
                        string OrderID = row.Cells[0].Value.ToString();
                        string WarehouseID = row.Cells[2].Value.ToString();
                        string Product = row.Cells[1].Value.ToString();

                        if (string.IsNullOrWhiteSpace(txtQuantity.Text) || txtQuantity.Text == "0")
                        {
                            throw new Exception("Please insert a quantity!\n");
                        }
                        string Quantity = txtQuantity.Text.ToString();


                        using (var context = new WMSEntities())
                        {
                            using (var dbContextTransaction = context.Database.BeginTransaction())
                            {
                                try
                                {
                                    context.AcceptSuggestion(Int32.Parse(OrderID), Int32.Parse(Quantity));
                                    context.SaveChanges();
                                    int warehouseID = Int32.Parse(WarehouseID);
                                    using (var context1 = new WMSEntities())
                                    {
                                        var result = (from p in context1.Products
                                                      where p.ProductName == ProductName
                                                      select p.ProductID).First();
                                        int prodID = Int32.Parse(result.ToString());
                                        Form Barcode = new FormBarcode(prodID);
                                        Barcode.ShowDialog();
                                    }
                                    Form RefillForm = new RefillForm(0, warehouseID, Product, Quantity, true);
                                    RefillForm.ShowDialog();
                                    dbContextTransaction.Commit();

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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvSuggestedReffils_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
