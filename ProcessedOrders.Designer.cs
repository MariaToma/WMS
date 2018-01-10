namespace WMS
{
    partial class ProcessedOrders
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
            this.gvProccOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvProccOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProccOrders
            // 
            this.gvProccOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProccOrders.Location = new System.Drawing.Point(11, 30);
            this.gvProccOrders.Margin = new System.Windows.Forms.Padding(2);
            this.gvProccOrders.Name = "gvProccOrders";
            this.gvProccOrders.RowTemplate.Height = 24;
            this.gvProccOrders.Size = new System.Drawing.Size(554, 162);
            this.gvProccOrders.TabIndex = 3;
            this.gvProccOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUnproccOrders_CellContentClick);
            // 
            // ProcessedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WMS.Properties.Resources.LIFT_warehouse_800x450;
            this.ClientSize = new System.Drawing.Size(634, 365);
            this.Controls.Add(this.gvProccOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProcessedOrders";
            this.Text = "ProcessedOrders";
            this.Load += new System.EventHandler(this.ProcessedOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProccOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvProccOrders;
    }
}