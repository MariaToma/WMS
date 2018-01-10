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
            this.btnRefillOrders = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnproccOrders
            // 
            this.btnUnproccOrders.Location = new System.Drawing.Point(540, 320);
            this.btnUnproccOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnproccOrders.Name = "btnUnproccOrders";
            this.btnUnproccOrders.Size = new System.Drawing.Size(130, 47);
            this.btnUnproccOrders.TabIndex = 0;
            this.btnUnproccOrders.Text = "Unprocessed Orders";
            this.btnUnproccOrders.UseVisualStyleBackColor = true;
            this.btnUnproccOrders.Click += new System.EventHandler(this.btnUnproccOrders_Click);
            // 
            // btnProcessedOrders
            // 
            this.btnProcessedOrders.Location = new System.Drawing.Point(540, 157);
            this.btnProcessedOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcessedOrders.Name = "btnProcessedOrders";
            this.btnProcessedOrders.Size = new System.Drawing.Size(130, 47);
            this.btnProcessedOrders.TabIndex = 1;
            this.btnProcessedOrders.Text = "See Processed Orders";
            this.btnProcessedOrders.UseVisualStyleBackColor = true;
            this.btnProcessedOrders.Click += new System.EventHandler(this.btnProcessedOrders_Click);
            // 
            // btnSuggestedRefill
            // 
            this.btnSuggestedRefill.Location = new System.Drawing.Point(32, 239);
            this.btnSuggestedRefill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuggestedRefill.Name = "btnSuggestedRefill";
            this.btnSuggestedRefill.Size = new System.Drawing.Size(130, 47);
            this.btnSuggestedRefill.TabIndex = 2;
            this.btnSuggestedRefill.Text = "Suggested refills";
            this.btnSuggestedRefill.UseVisualStyleBackColor = true;
            this.btnSuggestedRefill.Click += new System.EventHandler(this.btnSuggestedRefill_Click);
            // 
            // btnCurrentSales
            // 
            this.btnCurrentSales.Location = new System.Drawing.Point(540, 239);
            this.btnCurrentSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurrentSales.Name = "btnCurrentSales";
            this.btnCurrentSales.Size = new System.Drawing.Size(130, 47);
            this.btnCurrentSales.TabIndex = 3;
            this.btnCurrentSales.Text = "See Current Sales";
            this.btnCurrentSales.UseVisualStyleBackColor = true;
            this.btnCurrentSales.Click += new System.EventHandler(this.btnCurrentSales_Click);
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(32, 157);
            this.btnRefill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(130, 47);
            this.btnRefill.TabIndex = 4;
            this.btnRefill.Text = "Make a refill order";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(32, 320);
            this.btnStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(130, 47);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "See current stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnRefillOrders
            // 
            this.btnRefillOrders.Location = new System.Drawing.Point(32, 68);
            this.btnRefillOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefillOrders.Name = "btnRefillOrders";
            this.btnRefillOrders.Size = new System.Drawing.Size(130, 47);
            this.btnRefillOrders.TabIndex = 6;
            this.btnRefillOrders.Text = "See refill orders";
            this.btnRefillOrders.UseVisualStyleBackColor = true;
            this.btnRefillOrders.Click += new System.EventHandler(this.btnRefillOrders_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WMS.Properties.Resources.sistem_wms_228;
            this.pictureBox2.Location = new System.Drawing.Point(639, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WMS.Properties.Resources.Image11;
            this.pictureBox1.Location = new System.Drawing.Point(126, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(742, 444);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRefillOrders);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.btnCurrentSales);
            this.Controls.Add(this.btnSuggestedRefill);
            this.Controls.Add(this.btnProcessedOrders);
            this.Controls.Add(this.btnUnproccOrders);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "WMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnproccOrders;
        private System.Windows.Forms.Button btnProcessedOrders;
        private System.Windows.Forms.Button btnSuggestedRefill;
        private System.Windows.Forms.Button btnCurrentSales;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnRefillOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

