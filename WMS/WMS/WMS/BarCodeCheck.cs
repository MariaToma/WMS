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
    public partial class BarCodeCheck : Form
    {
        int progressVal = 0;
        public BarCodeCheck(int ProductID)
        {
            InitializeComponent();
            textBox1.AppendText(ProductID.ToString());
            MessageTextBox.Text = "Checking if it's the product you asked for...";
            this.timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            progressVal = progressBar1.Value;

            if (progressVal == progressBar1.Maximum)
            {
                timer1.Stop();
                LoadingTextBox.Text = "Checking done!";
                btnContinue.Enabled = true;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
