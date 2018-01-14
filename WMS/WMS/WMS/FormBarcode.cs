using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WMS
{
    public partial class FormBarcode : Form
    {
        public FormBarcode(int ProdID)
        {
            InitializeComponent();
            LabelCode.Text+= ProdID.ToString();
            int j;
            for (j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
           
        }

        private void FormBarcode_Load(object sender, EventArgs e)
        {
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void LabelCode_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
