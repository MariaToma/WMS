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
    public partial class PickingForm : Form
    {
        string Product;
        int rowID;
        int quantity;
        public PickingForm(string Product, int rowID,int quantity)
        {
            InitializeComponent();
            this.Product = Product;
            this.rowID = rowID;
            this.quantity = quantity;
            txtPicking.Text = "Picking started: ";
            txtPicking.AppendText(Environment.NewLine);
            int aux = quantity;
            for (int i = 1; i <= quantity; i++)
            {
                int shelf;
                if (aux % 20 == 0) shelf = (int)aux / 20;
                else shelf = (int)aux / 20 + 1;
                txtPicking.AppendText(String.Format("Picking {0} from row {1}, shelf {2}...", Product, rowID, shelf));
                txtPicking.AppendText(Environment.NewLine);
                aux--;
            }
            txtPicking.AppendText("Picking done!!!");
            txtPicking.AppendText(Environment.NewLine);
            txtPicking.AppendText(String.Format("{0} units of {1} are ready to be boarded!",quantity,Product));
            txtPicking.AppendText(Environment.NewLine);
            txtPicking.AppendText("Boarding...");
            txtPicking.AppendText(Environment.NewLine);
            txtPicking.AppendText("Boarding done! Products are ready to be delivered!");


        }

        private void txtPicking_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
