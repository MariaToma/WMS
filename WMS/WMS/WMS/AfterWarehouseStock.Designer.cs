namespace WMS
{
    partial class AfterWarehouseStock
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
            this.btnStockW = new System.Windows.Forms.Button();
            this.gvStockW = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an warehouse";
            // 
            // btnStockW
            // 
            this.btnStockW.Location = new System.Drawing.Point(142, 85);
            this.btnStockW.Margin = new System.Windows.Forms.Padding(2);
            this.btnStockW.Name = "btnStockW";
            this.btnStockW.Size = new System.Drawing.Size(131, 33);
            this.btnStockW.TabIndex = 2;
            this.btnStockW.Text = "See stock";
            this.btnStockW.UseVisualStyleBackColor = true;
            this.btnStockW.Click += new System.EventHandler(this.btnStockW_Click);
            // 
            // gvStockW
            // 
            this.gvStockW.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvStockW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvStockW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStockW.Location = new System.Drawing.Point(33, 150);
            this.gvStockW.Margin = new System.Windows.Forms.Padding(2);
            this.gvStockW.Name = "gvStockW";
            this.gvStockW.RowTemplate.Height = 24;
            this.gvStockW.Size = new System.Drawing.Size(283, 122);
            this.gvStockW.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WMS.Properties.Resources.sistem_wms_228;
            this.pictureBox1.Location = new System.Drawing.Point(299, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(180, 34);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(101, 21);
            this.cmbWarehouse.TabIndex = 5;
            // 
            // AfterWarehouseStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 290);
            this.Controls.Add(this.cmbWarehouse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvStockW);
            this.Controls.Add(this.btnStockW);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AfterWarehouseStock";
            this.Text = "AfterWarehouseStock";
            ((System.ComponentModel.ISupportInitialize)(this.gvStockW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStockW;
        private System.Windows.Forms.DataGridView gvStockW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbWarehouse;
    }
}