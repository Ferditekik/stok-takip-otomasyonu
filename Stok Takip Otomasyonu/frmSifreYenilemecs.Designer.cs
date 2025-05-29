namespace Stok_Takip_Otomasyonu
{
    partial class frmSifreYenilemecs
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
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblePosta = new System.Windows.Forms.Label();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtePosta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYenile
            // 
            this.btnYenile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYenile.BackColor = System.Drawing.Color.SpringGreen;
            this.btnYenile.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(160, 188);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(124, 36);
            this.btnYenile.TabIndex = 39;
            this.btnYenile.Text = "Gönder";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblePosta
            // 
            this.lblePosta.AutoSize = true;
            this.lblePosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblePosta.Location = new System.Drawing.Point(99, 129);
            this.lblePosta.Name = "lblePosta";
            this.lblePosta.Size = new System.Drawing.Size(79, 20);
            this.lblePosta.TabIndex = 29;
            this.lblePosta.Text = "E-Posta :";
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(67, 85);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(111, 20);
            this.lblKullanıcıAdı.TabIndex = 28;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(184, 78);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 27);
            this.txtKullaniciAdi.TabIndex = 34;
            // 
            // txtePosta
            // 
            this.txtePosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtePosta.Location = new System.Drawing.Point(184, 122);
            this.txtePosta.Name = "txtePosta";
            this.txtePosta.Size = new System.Drawing.Size(100, 27);
            this.txtePosta.TabIndex = 35;
            // 
            // frmSifreYenilemecs
            // 
            this.AcceptButton = this.btnYenile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(381, 308);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtePosta);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblePosta);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Name = "frmSifreYenilemecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSifreYenilemecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblePosta;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtePosta;
    }
}