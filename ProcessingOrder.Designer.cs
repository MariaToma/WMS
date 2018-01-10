namespace WMS
{
    partial class ProcessingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProcessing = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProcessing
            // 
            this.txtProcessing.AcceptsReturn = true;
            this.txtProcessing.AcceptsTab = true;
            this.txtProcessing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessing.Location = new System.Drawing.Point(30, 10);
            this.txtProcessing.Margin = new System.Windows.Forms.Padding(2);
            this.txtProcessing.Multiline = true;
            this.txtProcessing.Name = "txtProcessing";
            this.txtProcessing.Size = new System.Drawing.Size(537, 97);
            this.txtProcessing.TabIndex = 0;
            this.txtProcessing.WordWrap = false;
            this.txtProcessing.TextChanged += new System.EventHandler(this.txtProcessing_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(192, 140);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 24);
            this.progressBar1.TabIndex = 1;
            // 
            // txtDone
            // 
            this.txtDone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDone.Enabled = false;
            this.txtDone.Location = new System.Drawing.Point(180, 188);
            this.txtDone.Margin = new System.Windows.Forms.Padding(2);
            this.txtDone.Multiline = true;
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(196, 32);
            this.txtDone.TabIndex = 2;
            // 
            // ProcessingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WMS.Properties.Resources.Depozit;
            this.ClientSize = new System.Drawing.Size(624, 245);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtProcessing);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcessingOrder";
            this.Text = "ProcessingOrder";
            this.Load += new System.EventHandler(this.ProcessingOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessing;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtDone;
    }
}