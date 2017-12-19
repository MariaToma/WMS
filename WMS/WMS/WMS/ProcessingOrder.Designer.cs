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
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProcessing
            // 
            this.txtProcessing.AcceptsReturn = true;
            this.txtProcessing.AcceptsTab = true;
            this.txtProcessing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcessing.Location = new System.Drawing.Point(40, 12);
            this.txtProcessing.Multiline = true;
            this.txtProcessing.Name = "txtProcessing";
            this.txtProcessing.Size = new System.Drawing.Size(716, 119);
            this.txtProcessing.TabIndex = 0;
            this.txtProcessing.WordWrap = false;
            this.txtProcessing.TextChanged += new System.EventHandler(this.txtProcessing_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(256, 172);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 30);
            this.progressBar1.TabIndex = 1;
            // 
            // txtDone
            // 
            this.txtDone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDone.Enabled = false;
            this.txtDone.Location = new System.Drawing.Point(240, 231);
            this.txtDone.Multiline = true;
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(261, 40);
            this.txtDone.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(681, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 40);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ProcessingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 301);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtProcessing);
            this.Enabled = false;
            this.Name = "ProcessingOrder";
            this.Text = "ProcessingOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessing;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtDone;
        private System.Windows.Forms.Button btnOK;
    }
}