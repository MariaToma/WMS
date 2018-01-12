namespace WMS
{
    partial class CurrentSales
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
            this.warehousesComboBox = new System.Windows.Forms.ComboBox();
            this.txtCurrentSales = new System.Windows.Forms.TextBox();
            this.btnCurrentSales = new System.Windows.Forms.Button();
            this.gvCurrentSales = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentSales)).BeginInit();
            this.SuspendLayout();
            // 
            // warehousesComboBox
            // 
            this.warehousesComboBox.FormattingEnabled = true;
            this.warehousesComboBox.Location = new System.Drawing.Point(270, 74);
            this.warehousesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.warehousesComboBox.Name = "warehousesComboBox";
            this.warehousesComboBox.Size = new System.Drawing.Size(108, 21);
            this.warehousesComboBox.TabIndex = 0;
            this.warehousesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCurrentSales
            // 
            this.txtCurrentSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSales.Location = new System.Drawing.Point(26, 74);
            this.txtCurrentSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentSales.Name = "txtCurrentSales";
            this.txtCurrentSales.Size = new System.Drawing.Size(183, 17);
            this.txtCurrentSales.TabIndex = 1;
            // 
            // btnCurrentSales
            // 
            this.btnCurrentSales.Location = new System.Drawing.Point(430, 63);
            this.btnCurrentSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnCurrentSales.Name = "btnCurrentSales";
            this.btnCurrentSales.Size = new System.Drawing.Size(126, 63);
            this.btnCurrentSales.TabIndex = 2;
            this.btnCurrentSales.Text = "See current sales";
            this.btnCurrentSales.UseVisualStyleBackColor = true;
            this.btnCurrentSales.Click += new System.EventHandler(this.btnCurrentSales_Click);
            // 
            // gvCurrentSales
            // 
            this.gvCurrentSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCurrentSales.Location = new System.Drawing.Point(52, 149);
            this.gvCurrentSales.Margin = new System.Windows.Forms.Padding(2);
            this.gvCurrentSales.Name = "gvCurrentSales";
            this.gvCurrentSales.RowTemplate.Height = 24;
            this.gvCurrentSales.Size = new System.Drawing.Size(472, 139);
            this.gvCurrentSales.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(201, 309);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(191, 53);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Make a sales report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // CurrentSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WMS.Properties.Resources.refill;
            this.ClientSize = new System.Drawing.Size(582, 382);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.gvCurrentSales);
            this.Controls.Add(this.btnCurrentSales);
            this.Controls.Add(this.txtCurrentSales);
            this.Controls.Add(this.warehousesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CurrentSales";
            this.Text = "CurrentSales";
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox warehousesComboBox;
        private System.Windows.Forms.TextBox txtCurrentSales;
        private System.Windows.Forms.Button btnCurrentSales;
        private System.Windows.Forms.DataGridView gvCurrentSales;
        private System.Windows.Forms.Button btnReport;
    }
}