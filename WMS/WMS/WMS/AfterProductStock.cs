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
    public partial class AfterProductStock : Form
    {
        DataTable dbdataset = new DataTable();
        public AfterProductStock()
        {
            InitializeComponent();
            AutoCompleteText();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-PG9DG0T;Initial Catalog=WMS;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select * FROM Products ";


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dbdataset);



        }

        private void btnStockP_Click(object sender, EventArgs e)
        {
            string ProductName = Search_txt.Text;
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

        private void cmbStockP_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
