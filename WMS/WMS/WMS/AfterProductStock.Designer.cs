namespace WMS
{
    partial class AfterProductStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStockP = new System.Windows.Forms.ComboBox();
            this.btnStockP = new System.Windows.Forms.Button();
            this.gvStockP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the product name";
            // 
            // cmbStockP
            // 
            this.cmbStockP.FormattingEnabled = true;
            this.cmbStockP.Location = new System.Drawing.Point(361, 39);
            this.cmbStockP.Name = "cmbStockP";
            this.cmbStockP.Size = new System.Drawing.Size(150, 24);
            this.cmbStockP.TabIndex = 1;
            // 
            // btnStockP
            // 
            this.btnStockP.Location = new System.Drawing.Point(177, 93);
            this.btnStockP.Name = "btnStockP";
            this.btnStockP.Size = new System.Drawing.Size(184, 36);
            this.btnStockP.TabIndex = 2;
            this.btnStockP.Text = "See stock";
            this.btnStockP.UseVisualStyleBackColor = true;
            this.btnStockP.Click += new System.EventHandler(this.btnStockP_Click);
            // 
            // gvStockP
            // 
            this.gvStockP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvStockP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvStockP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStockP.Location = new System.Drawing.Point(70, 181);
            this.gvStockP.Name = "gvStockP";
            this.gvStockP.RowTemplate.Height = 24;
            this.gvStockP.Size = new System.Drawing.Size(397, 158);
            this.gvStockP.TabIndex = 3;
            // 
            // AfterProductStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 374);
            this.Controls.Add(this.gvStockP);
            this.Controls.Add(this.btnStockP);
            this.Controls.Add(this.cmbStockP);
            this.Controls.Add(this.label1);
            this.Name = "AfterProductStock";
            this.Text = "AfterProductStock";
            ((System.ComponentModel.ISupportInitialize)(this.gvStockP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStockP;
        private System.Windows.Forms.ComboBox cmbStockP;
        private System.Windows.Forms.DataGridView gvStockP;
    }
}