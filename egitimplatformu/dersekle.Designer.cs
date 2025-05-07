namespace egitimplatformu
{
    partial class dersekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dersekle));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_kayit = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_geri = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_kayit.SuspendLayout();
            this.pnl_geri.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 500;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(72, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pnl_kayit
            // 
            this.pnl_kayit.BackColor = System.Drawing.Color.Transparent;
            this.pnl_kayit.Controls.Add(this.panel2);
            this.pnl_kayit.Location = new System.Drawing.Point(72, 412);
            this.pnl_kayit.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_kayit.Name = "pnl_kayit";
            this.pnl_kayit.Size = new System.Drawing.Size(221, 53);
            this.pnl_kayit.TabIndex = 5;
            this.pnl_kayit.Click += new System.EventHandler(this.pnl_kayit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 123);
            this.panel2.TabIndex = 3;
            // 
            // pnl_geri
            // 
            this.pnl_geri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_geri.Controls.Add(this.panel3);
            this.pnl_geri.Location = new System.Drawing.Point(365, 412);
            this.pnl_geri.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_geri.Name = "pnl_geri";
            this.pnl_geri.Size = new System.Drawing.Size(140, 53);
            this.pnl_geri.TabIndex = 6;
            this.pnl_geri.Click += new System.EventHandler(this.pnl_geri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 123);
            this.panel3.TabIndex = 3;
            // 
            // dersekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_geri);
            this.Controls.Add(this.pnl_kayit);
            this.Controls.Add(this.listBox1);
            this.Name = "dersekle";
            this.Text = "dersekle";
            this.Load += new System.EventHandler(this.dersekle_Load);
            this.pnl_kayit.ResumeLayout(false);
            this.pnl_geri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_kayit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_geri;
        private System.Windows.Forms.Panel panel3;
    }
}