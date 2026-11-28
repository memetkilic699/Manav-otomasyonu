namespace Manav_otomasyonu
{
    partial class Form_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kullanici_adi = new System.Windows.Forms.Label();
            this.lbl_parola = new System.Windows.Forms.Label();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.btn_vazgec = new System.Windows.Forms.Button();
            this.btn_giris_yap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullanici_adi
            // 
            this.lbl_kullanici_adi.AutoSize = true;
            this.lbl_kullanici_adi.Location = new System.Drawing.Point(46, 51);
            this.lbl_kullanici_adi.Name = "lbl_kullanici_adi";
            this.lbl_kullanici_adi.Size = new System.Drawing.Size(85, 16);
            this.lbl_kullanici_adi.TabIndex = 0;
            this.lbl_kullanici_adi.Text = "Kullanıcı Adı :";
            // 
            // lbl_parola
            // 
            this.lbl_parola.AutoSize = true;
            this.lbl_parola.Location = new System.Drawing.Point(78, 89);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(53, 16);
            this.lbl_parola.TabIndex = 0;
            this.lbl_parola.Text = "Parola :";
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Location = new System.Drawing.Point(144, 48);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(162, 22);
            this.txt_kullanici_adi.TabIndex = 0;
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(144, 86);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.PasswordChar = '*';
            this.txt_parola.Size = new System.Drawing.Size(162, 22);
            this.txt_parola.TabIndex = 1;
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_vazgec.Location = new System.Drawing.Point(186, 132);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(82, 39);
            this.btn_vazgec.TabIndex = 3;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.UseVisualStyleBackColor = true;
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Location = new System.Drawing.Point(274, 132);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(82, 39);
            this.btn_giris_yap.TabIndex = 2;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.UseVisualStyleBackColor = true;
            // 
            // Form_giris
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_vazgec;
            this.ClientSize = new System.Drawing.Size(368, 183);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.lbl_parola);
            this.Controls.Add(this.lbl_kullanici_adi);
            this.Name = "Form_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manav Otomasyonu Giriş";
            this.Load += new System.EventHandler(this.Form_giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullanici_adi;
        private System.Windows.Forms.Label lbl_parola;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Button btn_vazgec;
        private System.Windows.Forms.Button btn_giris_yap;
    }
}

