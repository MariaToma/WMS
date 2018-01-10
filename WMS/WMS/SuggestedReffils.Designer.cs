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
            this.gvSuggestedReffils.Location = new System.Drawing.Point(11, 11);
            this.gvSuggestedReffils.Margin = new System.Windows.Forms.Padding(2);
            this.gvSuggestedReffils.Name = "gvSuggestedReffils";
            this.gvSuggestedReffils.RowTemplate.Height = 24;
            this.gvSuggestedReffils.Size = new System.Drawing.Size(554, 162);
            this.gvSuggestedReffils.TabIndex = 3;
            // 
            // btnAcceptSuggestion
            // 
            this.btnAcceptSuggestion.Location = new System.Drawing.Point(398, 249);
            this.btnAcceptSuggestion.Name = "btnAcceptSuggestion";
            this.btnAcceptSuggestion.Size = new System.Drawing.Size(167, 50);
            this.btnAcceptSuggestion.TabIndex = 4;
            this.btnAcceptSuggestion.Text = "Accept Suggestion";
            this.btnAcceptSuggestion.UseVisualStyleBackColor = true;
            this.btnAcceptSuggestion.Click += new System.EventHandler(this.btnAcceptSuggestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insert desired quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(223, 197);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(96, 31);
            this.txtQuantity.TabIndex = 7;
            // 
            // SuggestedReffils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WMS.Properties.Resources.csss;
            this.ClientSize = new System.Drawing.Size(610, 323);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptSuggestion);
            this.Controls.Add(this.gvSuggestedReffils);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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