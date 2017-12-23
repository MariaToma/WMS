namespace WMS
{
    partial class StockForm
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
            this.btnProductStock = new System.Windows.Forms.Button();
            this.btnWarehouseStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "See stock after:";
            // 
            // btnProductStock
            // 
            this.btnProductStock.Location = new System.Drawing.Point(51, 144);
            this.btnProductStock.Name = "btnProductStock";
            this.btnProductStock.Size = new System.Drawing.Size(133, 56);
            this.btnProductStock.TabIndex = 1;
            this.btnProductStock.Text = "A specific product";
            this.btnProductStock.UseVisualStyleBackColor = true;
            this.btnProductStock.Click += new System.EventHandler(this.btnProductStock_Click);
            // 
            // btnWarehouseStock
            // 
            this.btnWarehouseStock.Location = new System.Drawing.Point(300, 144);
            this.btnWarehouseStock.Name = "btnWarehouseStock";
            this.btnWarehouseStock.Size = new System.Drawing.Size(133, 56);
            this.btnWarehouseStock.TabIndex = 2;
            this.btnWarehouseStock.Text = "A specific warehouse";
            this.btnWarehouseStock.UseVisualStyleBackColor = true;
            this.btnWarehouseStock.Click += new System.EventHandler(this.btnWarehouseStock_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 240);
            this.Controls.Add(this.btnWarehouseStock);
            this.Controls.Add(this.btnProductStock);
            this.Controls.Add(this.label1);
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductStock;
        private System.Windows.Forms.Button btnWarehouseStock;
    }
}