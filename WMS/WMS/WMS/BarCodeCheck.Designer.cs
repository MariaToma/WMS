namespace WMS
{
    partial class BarCodeCheck
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LoadingTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(458, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1000000000214";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 59);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // LoadingTextBox
            // 
            this.LoadingTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.LoadingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoadingTextBox.Location = new System.Drawing.Point(181, 383);
            this.LoadingTextBox.Multiline = true;
            this.LoadingTextBox.Name = "LoadingTextBox";
            this.LoadingTextBox.Size = new System.Drawing.Size(152, 33);
            this.LoadingTextBox.TabIndex = 3;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MessageTextBox.Location = new System.Drawing.Point(21, 22);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(312, 150);
            this.MessageTextBox.TabIndex = 4;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(536, 392);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(149, 62);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue processing order";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Image = global::WMS.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(440, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarCodeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 466);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.LoadingTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Enabled = false;
            this.Name = "BarCodeCheck";
            this.Text = "BarCodeCheck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox LoadingTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button btnContinue;
    }
}