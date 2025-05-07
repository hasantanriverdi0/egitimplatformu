namespace egitimplatformu
{
    partial class kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit));
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.chc_sifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(112)))), ((int)(((byte)(70)))));
            this.btn_kayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_kayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_kayit.Location = new System.Drawing.Point(0, 562);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(436, 131);
            this.btn_kayit.TabIndex = 5;
            this.btn_kayit.Text = "KAYIT OL";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(14, 436);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(332, 31);
            this.txt_sifre.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(14, 326);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(332, 31);
            this.txt_ad.TabIndex = 3;
            // 
            // chc_sifre
            // 
            this.chc_sifre.AutoSize = true;
            this.chc_sifre.BackColor = System.Drawing.Color.Transparent;
            this.chc_sifre.ForeColor = System.Drawing.Color.Black;
            this.chc_sifre.Location = new System.Drawing.Point(14, 484);
            this.chc_sifre.Name = "chc_sifre";
            this.chc_sifre.Size = new System.Drawing.Size(174, 29);
            this.chc_sifre.TabIndex = 6;
            this.chc_sifre.Text = "Şifreyi Göster";
            this.chc_sifre.UseVisualStyleBackColor = false;
            this.chc_sifre.CheckedChanged += new System.EventHandler(this.chc_sifre_CheckedChanged);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 843);
            this.Controls.Add(this.chc_sifre);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Eğitim Platformu";
            this.Load += new System.EventHandler(this.kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.CheckBox chc_sifre;
    }
}