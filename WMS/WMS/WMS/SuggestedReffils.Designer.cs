namespace WMS
{
    partial class SuggestedReffils
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
            this.gvSuggestedReffils = new System.Windows.Forms.DataGridView();
            this.btnAcceptSuggestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuggestedReffils)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSuggestedReffils
            // 
            this.gvSuggestedReffils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuggestedReffils.Location = new System.Drawing.Point(15, 14);
            this.gvSuggestedReffils.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvSuggestedReffils.Name = "gvSuggestedReffils";
            this.gvSuggestedReffils.RowTemplate.Height = 24;
            this.gvSuggestedReffils.Size = new System.Drawing.Size(739, 199);
            this.gvSuggestedReffils.TabIndex = 3;
            // 
            // btnAcceptSuggestion
            // 
            this.btnAcceptSuggestion.Location = new System.Drawing.Point(531, 307);
            this.btnAcceptSuggestion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptSuggestion.Name = "btnAcceptSuggestion";
            this.btnAcceptSuggestion.Size = new System.Drawing.Size(223, 62);
            this.btnAcceptSuggestion.TabIndex = 4;
            this.btnAcceptSuggestion.Text = "Accept Suggestion";
            this.btnAcceptSuggestion.UseVisualStyleBackColor = true;
            this.btnAcceptSuggestion.Click += new System.EventHandler(this.btnAcceptSuggestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insert desired quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(297, 243);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(127, 37);
            this.txtQuantity.TabIndex = 7;
            // 
            // SuggestedReffils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 398);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptSuggestion);
            this.Controls.Add(this.gvSuggestedReffils);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuggestedReffils";
            this.Text = "SuggestedReffils";
            this.Load += new System.EventHandler(this.SuggestedReffils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSuggestedReffils)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvSuggestedReffils;
        private System.Windows.Forms.Button btnAcceptSuggestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}