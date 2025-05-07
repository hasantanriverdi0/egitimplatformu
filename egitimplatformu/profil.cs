using System;
using System.IO;
using System.Windows.Forms;

namespace egitimplatformu
{
    public partial class profil : Form
    {
        string kullaniciAdi = "";

        // Kullanıcı adı, anasayfa formundan alınarak profil formuna iletiliyor
        public profil(string gelenAd)
        {
            InitializeComponent();
            kullaniciAdi = gelenAd;  // Gelen kullanıcı adını alıyoruz
        }

        private void pnl_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfaForm = new anasayfa(kullaniciAdi);  // Kullanıcı adı ile anasayfa açılıyor
            anasayfaForm.Show();
            this.Hide();
        }

        // Profil yüklendiğinde, ders sayısını dosyadan alıyoruz
        private void profil_Load(object sender, EventArgs e)
        {
            // Kullanıcı adını label2'ye yazıyoruz
            label2.Text = "Kullanıcı Adı: " + kullaniciAdi;

            // Derslerin sayısını alıyoruz (dersler.txt dosyasındaki satır sayısı)
            int dersSayisi = GetDersSayisi();

            // Ders sayısını label1'e yazdırıyoruz
            label1.Text = "Ders Sayısı: " + dersSayisi.ToString();
        }

        private int GetDersSayisi()
        {
            int sayac = 0;

            // Dersler.txt dosyasını kontrol edip ders sayısını hesaplıyoruz
            if (File.Exists("dersler.txt"))
            {
                string[] dersler = File.ReadAllLines("dersler.txt");
                sayac = dersler.Length;  // Satır sayısını alıyoruz (bu ders sayısını verecektir)
            }

            return sayac;
        }
    }
}
