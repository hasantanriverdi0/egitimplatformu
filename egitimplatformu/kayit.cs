using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace egitimplatformu
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string kayitSatiri = ad + "|" + sifre;
            File.AppendAllText("kullanicilar.txt", kayitSatiri + Environment.NewLine);

            MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.");
            this.Hide();
            giris girisSayfa = new giris();
            girisSayfa.Show();
        }

        private void kayit_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void chc_sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_sifre.Checked)
            {
                txt_sifre.PasswordChar = '\0'; 
            }
            else
            {
                txt_sifre.PasswordChar = '*'; 
            }
        }
    }
}
