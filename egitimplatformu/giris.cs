using System;
using System.IO;
using System.Windows.Forms;

namespace egitimplatformu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();
            string sifre = txt_sifre.Text.Trim();

            if (!File.Exists("kullanicilar.txt"))
            {
                MessageBox.Show("Kayıtlı kullanıcı bulunamadı.");
                return;
            }

            bool girisBasarili = false;
            string[] satirlar = File.ReadAllLines("kullanicilar.txt");

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split('|');
                if (parcalar.Length == 2)
                {
                    if (parcalar[0] == ad && parcalar[1] == sifre)
                    {
                        girisBasarili = true;
                        break;
                    }
                }
            }

            if (girisBasarili)
            {
                MessageBox.Show("Giriş başarılı!");
                this.Hide();
                anasayfa anaForm = new anasayfa(ad); // dersekle yerine anasayfa çağrılıyor
                anaForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayit kayitForm = new kayit();
            kayitForm.Show();
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
