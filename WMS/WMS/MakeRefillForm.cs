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
    public partial class MakeRefillForm : Form
    {
        public MakeRefillForm()
        {
            InitializeComponent();
            using (var context = new WMSEntities())
            {
                cmbWarehouse.DataSource = (from c in context.Warehouses
                                           select c.WarehouseID
                                               ).ToList();

                cmdProducts.DataSource = (from p in context.Products
                                          select p.ProductName
                                          ).Distinct().ToList();
            }
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            int warehouseID = Int32.Parse(cmbWarehouse.SelectedItem.ToString());
            string ProductName = cmdProducts.SelectedItem.ToString();
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please insert a quantity!!");
                return;
            }
            int quantity = Int32.Parse(txtQuantity.Text.ToString());
            if (quantity <= 0)
            {
                MessageBox.Show("Please insert a valid quantity (greater than zero)!!");
                txtQuantity.Clear();
                txtQuantity.Focus();
                return;
            }
            Form Refill = new RefillForm(0, warehouseID, ProductName, txtQuantity.Text.ToString(),true);
            Refill.ShowDialog();

            using (var context = new WMSEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.RefillFromWarehouse(0, warehouseID, quantity, ProductName);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        dbContextTransaction.Rollback();
                    }
                 
                }
            }
        }

        private void MakeRefillForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
