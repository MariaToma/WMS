﻿using System;
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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            
        }

        private void btnProductStock_Click(object sender, EventArgs e)
        {
            Form StockP = new AfterProductStock();
            StockP.ShowDialog();
        }

        private void btnWarehouseStock_Click(object sender, EventArgs e)
        {
            Form StockW = new AfterWarehouseStock();
            StockW.ShowDialog();
        }
    }
}
