namespace WMS
{
    partial class RefillOrders
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
            this.gvRefillOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRefillOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRefillOrders
            // 
            this.gvRefillOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRefillOrders.Location = new System.Drawing.Point(38, 29);
            this.gvRefillOrders.Name = "gvRefillOrders";
            this.gvRefillOrders.RowTemplate.Height = 24;
            this.gvRefillOrders.Size = new System.Drawing.Size(633, 212);
            this.gvRefillOrders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Order source=Id of the souce warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Order destination=Id of the destination warehouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "** Id=0 ----> factory";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(496, 284);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(141, 51);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "See more details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // RefillOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 368);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvRefillOrders);
            this.Name = "RefillOrders";
            this.Text = "RefillOrders";
            this.Load += new System.EventHandler(this.RefillOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRefillOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRefillOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetails;
    }
}