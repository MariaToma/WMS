using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class Form1 : Form
    {
        DataTable dbdataset = new DataTable();
        public Form1()
        {
            InitializeComponent();
            AutoCompleteText();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.;Initial Catalog=WMS;Integrated Security=True";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Select * FROM Products ";

            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dbdataset);
            
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
                foreach(var a in test)
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
