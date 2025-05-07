namespace egitimplatformu
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.pnl_ders = new System.Windows.Forms.Panel();
            this.pnl_gorus = new System.Windows.Forms.Panel();
            this.pnl_profil = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_görüs = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_ders.SuspendLayout();
            this.pnl_görüs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ekle.Location = new System.Drawing.Point(52, 69);
            this.pnl_ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(144, 140);
            this.pnl_ekle.TabIndex = 0;
            this.pnl_ekle.Click += new System.EventHandler(this.pnl_ekle_Click);
            // 
            // pnl_ders
            // 
            this.pnl_ders.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ders.Controls.Add(this.pnl_gorus);
            this.pnl_ders.Location = new System.Drawing.Point(250, 69);
            this.pnl_ders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_ders.Name = "pnl_ders";
            this.pnl_ders.Size = new System.Drawing.Size(146, 137);
            this.pnl_ders.TabIndex = 1;
            this.pnl_ders.Click += new System.EventHandler(this.pnl_ders_Click);
            // 
            // pnl_gorus
            // 
            this.pnl_gorus.BackColor = System.Drawing.Color.Transparent;
            this.pnl_gorus.Location = new System.Drawing.Point(0, 152);
            this.pnl_gorus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_gorus.Name = "pnl_gorus";
            this.pnl_gorus.Size = new System.Drawing.Size(130, 123);
            this.pnl_gorus.TabIndex = 3;
            // 
            // pnl_profil
            // 
            this.pnl_profil.BackColor = System.Drawing.Color.Transparent;
            this.pnl_profil.Location = new System.Drawing.Point(52, 236);
            this.pnl_profil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_profil.Name = "pnl_profil";
            this.pnl_profil.Size = new System.Drawing.Size(144, 141);
            this.pnl_profil.TabIndex = 2;
            this.pnl_profil.Click += new System.EventHandler(this.pnl_profil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(56, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoş Geldin Hasan";
            // 
            // pnl_görüs
            // 
            this.pnl_görüs.BackColor = System.Drawing.Color.Transparent;
            this.pnl_görüs.Controls.Add(this.panel2);
            this.pnl_görüs.Location = new System.Drawing.Point(249, 236);
            this.pnl_görüs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_görüs.Name = "pnl_görüs";
            this.pnl_görüs.Size = new System.Drawing.Size(146, 137);
            this.pnl_görüs.TabIndex = 4;
            this.pnl_görüs.Click += new System.EventHandler(this.pnl_görüs_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 123);
            this.panel2.TabIndex = 3;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 440);
            this.Controls.Add(this.pnl_görüs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_profil);
            this.Controls.Add(this.pnl_ders);
            this.Controls.Add(this.pnl_ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Eğitim Sistemi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.pnl_ders.ResumeLayout(false);
            this.pnl_görüs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Panel pnl_ders;
        private System.Windows.Forms.Panel pnl_profil;
        private System.Windows.Forms.Panel pnl_gorus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_görüs;
        private System.Windows.Forms.Panel panel2;
    }
}