namespace WMS
{
    partial class MainForm
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
            this.btnUnproccOrders = new System.Windows.Forms.Button();
            this.btnProcessedOrders = new System.Windows.Forms.Button();
            this.btnSuggestedRefill = new System.Windows.Forms.Button();
            this.btnCurrentSales = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnproccOrders
            // 
            this.btnUnproccOrders.Location = new System.Drawing.Point(773, 369);
            this.btnUnproccOrders.Name = "btnUnproccOrders";
            this.btnUnproccOrders.Size = new System.Drawing.Size(173, 58);
            this.btnUnproccOrders.TabIndex = 0;
            this.btnUnproccOrders.Text = "Unprocessed Orders";
            this.btnUnproccOrders.UseVisualStyleBackColor = true;
            this.btnUnproccOrders.Click += new System.EventHandler(this.btnUnproccOrders_Click);
            // 
            // btnProcessedOrders
            // 
            this.btnProcessedOrders.Location = new System.Drawing.Point(411, 369);
            this.btnProcessedOrders.Name = "btnProcessedOrders";
            this.btnProcessedOrders.Size = new System.Drawing.Size(173, 58);
            this.btnProcessedOrders.TabIndex = 1;
            this.btnProcessedOrders.Text = "See Processed Orders";
            this.btnProcessedOrders.UseVisualStyleBackColor = true;
            // 
            // btnSuggestedRefill
            // 
            this.btnSuggestedRefill.Location = new System.Drawing.Point(43, 369);
            this.btnSuggestedRefill.Name = "btnSuggestedRefill";
            this.btnSuggestedRefill.Size = new System.Drawing.Size(173, 58);
            this.btnSuggestedRefill.TabIndex = 2;
            this.btnSuggestedRefill.Text = "Suggested refills";
            this.btnSuggestedRefill.UseVisualStyleBackColor = true;
            // 
            // btnCurrentSales
            // 
            this.btnCurrentSales.Location = new System.Drawing.Point(411, 475);
            this.btnCurrentSales.Name = "btnCurrentSales";
            this.btnCurrentSales.Size = new System.Drawing.Size(173, 58);
            this.btnCurrentSales.TabIndex = 3;
            this.btnCurrentSales.Text = "See Current Sales";
            this.btnCurrentSales.UseVisualStyleBackColor = true;
            this.btnCurrentSales.Click += new System.EventHandler(this.btnCurrentSales_Click);
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(773, 475);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(173, 58);
            this.btnRefill.TabIndex = 4;
            this.btnRefill.Text = "Make a refill order";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(43, 475);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(173, 58);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "See current stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 547);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.btnCurrentSales);
            this.Controls.Add(this.btnSuggestedRefill);
            this.Controls.Add(this.btnProcessedOrders);
            this.Controls.Add(this.btnUnproccOrders);
            this.Name = "MainForm";
            this.Text = "WMS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnproccOrders;
        private System.Windows.Forms.Button btnProcessedOrders;
        private System.Windows.Forms.Button btnSuggestedRefill;
        private System.Windows.Forms.Button btnCurrentSales;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnStock;
    }
}

