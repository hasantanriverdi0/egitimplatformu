namespace egitimplatformu
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.chc_sifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(6, 170);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(168, 19);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(6, 227);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(168, 19);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(112)))), ((int)(((byte)(70)))));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.Transparent;
            this.btn_giris.Location = new System.Drawing.Point(0, 292);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(218, 68);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(59)))), ((int)(((byte)(129)))));
            this.btn_kayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.ForeColor = System.Drawing.Color.Transparent;
            this.btn_kayıt.Location = new System.Drawing.Point(149, 376);
            this.btn_kayıt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(147, 38);
            this.btn_kayıt.TabIndex = 3;
            this.btn_kayıt.Text = "Kayıt Ol";
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // chc_sifre
            // 
            this.chc_sifre.AutoSize = true;
            this.chc_sifre.BackColor = System.Drawing.Color.Transparent;
            this.chc_sifre.ForeColor = System.Drawing.Color.Black;
            this.chc_sifre.Location = new System.Drawing.Point(6, 246);
            this.chc_sifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chc_sifre.Name = "chc_sifre";
            this.chc_sifre.Size = new System.Drawing.Size(88, 17);
            this.chc_sifre.TabIndex = 4;
            this.chc_sifre.Text = "Şifreyi Göster";
            this.chc_sifre.UseVisualStyleBackColor = false;
            this.chc_sifre.CheckedChanged += new System.EventHandler(this.chc_sifre_CheckedChanged);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 439);
            this.Controls.Add(this.chc_sifre);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Eğitim Platformu";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.CheckBox chc_sifre;
    }
}

