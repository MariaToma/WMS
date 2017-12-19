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
    public partial class RefillForm : Form
    {
        public RefillForm(int source, int destination, string product,string quantity)
        {
            InitializeComponent();
            if (source == 0)
            {
                textBox1.Text = String.Format(String.Format("Can not find enough units in any warehouse! Refilling warehouse {0} from factory with product -> {1}, quantity-> {2}...", destination,product, quantity));
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
            }
            else
            {
                textBox1.Text = String.Format("Refilling warehouse {0} from warehouse {1} with product -> {2}, quantity-> {3}...", destination, source, product, quantity);
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
            }
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
            txtDone.Text = "Done!";
        }
            private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
