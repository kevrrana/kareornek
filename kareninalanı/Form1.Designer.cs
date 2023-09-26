namespace kareninalanı
{
    partial class Form1
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
            this.lblKisaKenar = new System.Windows.Forms.Label();
            this.lblUzunKenar = new System.Windows.Forms.Label();
            this.txtKisaKenar = new System.Windows.Forms.TextBox();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblÇevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKisaKenar
            // 
            this.lblKisaKenar.AutoSize = true;
            this.lblKisaKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisaKenar.Location = new System.Drawing.Point(67, 68);
            this.lblKisaKenar.Name = "lblKisaKenar";
            this.lblKisaKenar.Size = new System.Drawing.Size(90, 18);
            this.lblKisaKenar.TabIndex = 0;
            this.lblKisaKenar.Text = "Kısa Kenar";
            // 
            // lblUzunKenar
            // 
            this.lblUzunKenar.AutoSize = true;
            this.lblUzunKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunKenar.Location = new System.Drawing.Point(67, 96);
            this.lblUzunKenar.Name = "lblUzunKenar";
            this.lblUzunKenar.Size = new System.Drawing.Size(96, 18);
            this.lblUzunKenar.TabIndex = 1;
            this.lblUzunKenar.Text = "Uzun Kenar";
            // 
            // txtKisaKenar
            // 
            this.txtKisaKenar.Location = new System.Drawing.Point(184, 71);
            this.txtKisaKenar.Name = "txtKisaKenar";
            this.txtKisaKenar.Size = new System.Drawing.Size(146, 20);
            this.txtKisaKenar.TabIndex = 2;
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(184, 97);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(146, 20);
            this.txtUzunKenar.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(130, 143);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 53);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblÇevre
            // 
            this.lblÇevre.AutoSize = true;
            this.lblÇevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÇevre.Location = new System.Drawing.Point(67, 290);
            this.lblÇevre.Name = "lblÇevre";
            this.lblÇevre.Size = new System.Drawing.Size(62, 18);
            this.lblÇevre.TabIndex = 5;
            this.lblÇevre.Text = "Çevre :";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Location = new System.Drawing.Point(67, 250);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(50, 18);
            this.lblAlan.TabIndex = 7;
            this.lblAlan.Text = "Alan :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblÇevre);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUzunKenar);
            this.Controls.Add(this.txtKisaKenar);
            this.Controls.Add(this.lblUzunKenar);
            this.Controls.Add(this.lblKisaKenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKisaKenar;
        private System.Windows.Forms.Label lblUzunKenar;
        private System.Windows.Forms.TextBox txtKisaKenar;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblÇevre;
        private System.Windows.Forms.Label lblAlan;
    }
}

