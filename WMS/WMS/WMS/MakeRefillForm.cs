using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WMS
{
    public partial class MakeRefillForm : Form
    {
        DataTable dbdataset = new DataTable();
        public MakeRefillForm()
        {
            InitializeComponent();
            AutoCompleteText();
            using (var context = new WMSEntities())
            {
                cmbWarehouse.DataSource = (from c in context.Warehouses
                                           select c.WarehouseID
                                               ).ToList();

            }
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.;Initial Catalog=WMS;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select * FROM Products ";


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dbdataset);
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            int warehouseID = Int32.Parse(cmbWarehouse.SelectedItem.ToString());
            string ProductName = Search_txt.Text;
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
            using (var context = new WMSEntities())
            {
                var result = (from p in context.Products
                              where p.ProductName == ProductName
                              select p.ProductID).First();
                int prodID = Int32.Parse(result.ToString());
                Form Barcode = new FormBarcode(prodID);
                Barcode.ShowDialog();
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

        private void cmdProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void AutoCompleteText()
        {
            using (var context = new WMSEntities())
            {


                Search_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Search_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                var test = (from p in context.Products
                            select p.ProductName
                                          ).Distinct().ToList();
                foreach (var a in test)
                {
                    coll.Add(a);
                }
                Search_txt.AutoCompleteCustomSource = coll;
            }

        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            DataGridView DataGridViwe1 = new DataGridView();
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("ProductName LIKE '%{0}%'", Search_txt.Text);
            DataGridViwe1.DataSource = DV;

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
