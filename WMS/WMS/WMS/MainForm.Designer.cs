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
            this.SuspendLayout();
            // 
            // btnUnproccOrders
            // 
            this.btnUnproccOrders.Location = new System.Drawing.Point(772, 427);
            this.btnUnproccOrders.Name = "btnUnproccOrders";
            this.btnUnproccOrders.Size = new System.Drawing.Size(173, 58);
            this.btnUnproccOrders.TabIndex = 0;
            this.btnUnproccOrders.Text = "Unprocessed Orders";
            this.btnUnproccOrders.UseVisualStyleBackColor = true;
            this.btnUnproccOrders.Click += new System.EventHandler(this.btnUnproccOrders_Click);
            // 
            // btnProcessedOrders
            // 
            this.btnProcessedOrders.Location = new System.Drawing.Point(438, 427);
            this.btnProcessedOrders.Name = "btnProcessedOrders";
            this.btnProcessedOrders.Size = new System.Drawing.Size(173, 58);
            this.btnProcessedOrders.TabIndex = 1;
            this.btnProcessedOrders.Text = "See Processed Orders";
            this.btnProcessedOrders.UseVisualStyleBackColor = true;
            // 
            // btnSuggestedRefill
            // 
            this.btnSuggestedRefill.Location = new System.Drawing.Point(108, 427);
            this.btnSuggestedRefill.Name = "btnSuggestedRefill";
            this.btnSuggestedRefill.Size = new System.Drawing.Size(173, 58);
            this.btnSuggestedRefill.TabIndex = 2;
            this.btnSuggestedRefill.Text = "Suggested refills";
            this.btnSuggestedRefill.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 547);
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
    }
}

