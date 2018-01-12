namespace WMS
{
    partial class PickingForm
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
            this.txtPicking = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPicking
            // 
            this.txtPicking.Location = new System.Drawing.Point(9, 10);
            this.txtPicking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPicking.Multiline = true;
            this.txtPicking.Name = "txtPicking";
            this.txtPicking.ReadOnly = true;
            this.txtPicking.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPicking.Size = new System.Drawing.Size(356, 140);
            this.txtPicking.TabIndex = 0;
            this.txtPicking.WordWrap = false;
            this.txtPicking.TextChanged += new System.EventHandler(this.txtPicking_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PickingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WMS.Properties.Resources.LIFT_warehouse_800x450;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPicking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PickingForm";
            this.Text = "PickingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPicking;
        private System.Windows.Forms.Button button1;
    }
}