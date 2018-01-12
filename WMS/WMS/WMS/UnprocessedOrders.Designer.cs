namespace WMS
{
    partial class UnprocessedOrders
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
            this.gvUnproccOrders = new System.Windows.Forms.DataGridView();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnproccOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvUnproccOrders
            // 
            this.gvUnproccOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUnproccOrders.Location = new System.Drawing.Point(24, 10);
            this.gvUnproccOrders.Margin = new System.Windows.Forms.Padding(2);
            this.gvUnproccOrders.Name = "gvUnproccOrders";
            this.gvUnproccOrders.RowTemplate.Height = 24;
            this.gvUnproccOrders.Size = new System.Drawing.Size(554, 162);
            this.gvUnproccOrders.TabIndex = 0;
            this.gvUnproccOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUnproccOrders_CellContentClick);
            // 
            // txtSelect
            // 
            this.txtSelect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSelect.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSelect.Location = new System.Drawing.Point(24, 188);
            this.txtSelect.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelect.Multiline = true;
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(177, 18);
            this.txtSelect.TabIndex = 1;
            this.txtSelect.Text = "*Select the order you want to process";
            this.txtSelect.TextChanged += new System.EventHandler(this.txtSelect_TextChanged);
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(610, 63);
            this.btnProcessOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(86, 58);
            this.btnProcessOrder.TabIndex = 2;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // UnprocessedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WMS.Properties.Resources.warehouse;
            this.ClientSize = new System.Drawing.Size(719, 371);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.gvUnproccOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnprocessedOrders";
            this.Text = "UnprocessedOrders";
            ((System.ComponentModel.ISupportInitialize)(this.gvUnproccOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvUnproccOrders;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnProcessOrder;
    }
}