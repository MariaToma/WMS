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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUnproccOrders_Click(object sender, EventArgs e)
        {
            Form form = new UnprocessedOrders();
            form.Show();
        }

        private void btnCurrentSales_Click(object sender, EventArgs e)
        {
            Form currentSales = new CurrentSales();
            currentSales.ShowDialog();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            Form MakeRefill = new MakeRefillForm();
            MakeRefill.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Form Stock = new StockForm();
            Stock.ShowDialog();
        }
    }
}
