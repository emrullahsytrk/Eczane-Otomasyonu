namespace EBİS__GİRİŞ_PANELİ
{
    partial class Ebis_Giris_Paneli_Frm
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
            this.Kullanici_Giris_Btn_GirisPaneli = new System.Windows.Forms.Button();
            this.Kullanici_TC_Lbl_GirisPaneli = new System.Windows.Forms.Label();
            this.Kullanici_Sifre_Lbl_GirisPaneli = new System.Windows.Forms.Label();
            this.Kullanici_Sife_TxtBx_GirisPanel = new System.Windows.Forms.TextBox();
            this.GirisPaneli_GroupBox_EbisGirisPaneli = new System.Windows.Forms.GroupBox();
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli = new System.Windows.Forms.MaskedTextBox();
            this.GirisPaneli_GroupBox_EbisGirisPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kullanici_Giris_Btn_GirisPaneli
            // 
            this.Kullanici_Giris_Btn_GirisPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Giris_Btn_GirisPaneli.Location = new System.Drawing.Point(166, 138);
            this.Kullanici_Giris_Btn_GirisPaneli.Name = "Kullanici_Giris_Btn_GirisPaneli";
            this.Kullanici_Giris_Btn_GirisPaneli.Size = new System.Drawing.Size(139, 44);
            this.Kullanici_Giris_Btn_GirisPaneli.TabIndex = 3;
            this.Kullanici_Giris_Btn_GirisPaneli.Text = "GİRİŞ";
            this.Kullanici_Giris_Btn_GirisPaneli.UseVisualStyleBackColor = true;
            this.Kullanici_Giris_Btn_GirisPaneli.Click += new System.EventHandler(this.Kullanici_Giris_Btn_Click);
            // 
            // Kullanici_TC_Lbl_GirisPaneli
            // 
            this.Kullanici_TC_Lbl_GirisPaneli.AutoSize = true;
            this.Kullanici_TC_Lbl_GirisPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_TC_Lbl_GirisPaneli.Location = new System.Drawing.Point(23, 52);
            this.Kullanici_TC_Lbl_GirisPaneli.Name = "Kullanici_TC_Lbl_GirisPaneli";
            this.Kullanici_TC_Lbl_GirisPaneli.Size = new System.Drawing.Size(134, 24);
            this.Kullanici_TC_Lbl_GirisPaneli.TabIndex = 1;
            this.Kullanici_TC_Lbl_GirisPaneli.Text = "Kullanıcı TC :";
            // 
            // Kullanici_Sifre_Lbl_GirisPaneli
            // 
            this.Kullanici_Sifre_Lbl_GirisPaneli.AutoSize = true;
            this.Kullanici_Sifre_Lbl_GirisPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Sifre_Lbl_GirisPaneli.Location = new System.Drawing.Point(96, 99);
            this.Kullanici_Sifre_Lbl_GirisPaneli.Name = "Kullanici_Sifre_Lbl_GirisPaneli";
            this.Kullanici_Sifre_Lbl_GirisPaneli.Size = new System.Drawing.Size(64, 24);
            this.Kullanici_Sifre_Lbl_GirisPaneli.TabIndex = 2;
            this.Kullanici_Sifre_Lbl_GirisPaneli.Text = "Şifre :";
            // 
            // Kullanici_Sife_TxtBx_GirisPanel
            // 
            this.Kullanici_Sife_TxtBx_GirisPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Sife_TxtBx_GirisPanel.Location = new System.Drawing.Point(166, 94);
            this.Kullanici_Sife_TxtBx_GirisPanel.Name = "Kullanici_Sife_TxtBx_GirisPanel";
            this.Kullanici_Sife_TxtBx_GirisPanel.Size = new System.Drawing.Size(139, 29);
            this.Kullanici_Sife_TxtBx_GirisPanel.TabIndex = 2;
            this.Kullanici_Sife_TxtBx_GirisPanel.UseSystemPasswordChar = true;
            // 
            // GirisPaneli_GroupBox_EbisGirisPaneli
            // 
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Controls.Add(this.Kullanici_Adİ_MaskedTextBox_GirisPaneli);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Controls.Add(this.Kullanici_Sife_TxtBx_GirisPanel);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Controls.Add(this.Kullanici_Sifre_Lbl_GirisPaneli);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Controls.Add(this.Kullanici_TC_Lbl_GirisPaneli);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Controls.Add(this.Kullanici_Giris_Btn_GirisPaneli);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Location = new System.Drawing.Point(12, 12);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Name = "GirisPaneli_GroupBox_EbisGirisPaneli";
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Size = new System.Drawing.Size(372, 219);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.TabIndex = 5;
            this.GirisPaneli_GroupBox_EbisGirisPaneli.TabStop = false;
            this.GirisPaneli_GroupBox_EbisGirisPaneli.Text = "Giriş Paneli";
            // 
            // Kullanici_Adİ_MaskedTextBox_GirisPaneli
            // 
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.Location = new System.Drawing.Point(166, 50);
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.Mask = "00000000000";
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.Name = "Kullanici_Adİ_MaskedTextBox_GirisPaneli";
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.Size = new System.Drawing.Size(139, 29);
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.TabIndex = 1;
            this.Kullanici_Adİ_MaskedTextBox_GirisPaneli.ValidatingType = typeof(int);
            // 
            // Ebis_Giris_Paneli_Frm
            // 
            this.AcceptButton = this.Kullanici_Giris_Btn_GirisPaneli;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 245);
            this.Controls.Add(this.GirisPaneli_GroupBox_EbisGirisPaneli);
            this.Name = "Ebis_Giris_Paneli_Frm";
            this.Text = "EBİS GİRİŞ PANELİ";
            this.GirisPaneli_GroupBox_EbisGirisPaneli.ResumeLayout(false);
            this.GirisPaneli_GroupBox_EbisGirisPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kullanici_Giris_Btn_GirisPaneli;
        private System.Windows.Forms.Label Kullanici_TC_Lbl_GirisPaneli;
        private System.Windows.Forms.Label Kullanici_Sifre_Lbl_GirisPaneli;
        private System.Windows.Forms.TextBox Kullanici_Sife_TxtBx_GirisPanel;
        private System.Windows.Forms.GroupBox GirisPaneli_GroupBox_EbisGirisPaneli;
        private System.Windows.Forms.MaskedTextBox Kullanici_Adİ_MaskedTextBox_GirisPaneli;
    }
}

