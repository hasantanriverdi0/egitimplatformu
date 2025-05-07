using System;
using System.Windows.Forms;

namespace egitimplatformu
{
    public partial class anasayfa : Form
    {
        string kullaniciAdi = "";

        public anasayfa(string gelenAd)
        {
            InitializeComponent();
            kullaniciAdi = gelenAd;
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi))
            {
                label1.Text = "Hoş geldin, " + kullaniciAdi;
            }
            else
            {
                label1.Text = "Hoş geldin, kullanıcıadı";
            }
        }

        private void pnl_görüs_Click(object sender, EventArgs e)
        {
            this.Hide();
            gorus goruss = new gorus();
            goruss.Show();
        }

        private void pnl_ekle_Click(object sender, EventArgs e)
        {
            dersekle dersekle = new dersekle(kullaniciAdi); // Kullanıcı adını 'dersekle' formuna ilet
            dersekle.Show();
            this.Hide();
        }

        private void pnl_ders_Click(object sender, EventArgs e)
        {
            // Burada dersekle formundan seçilen dersin alınması gerekiyor.
            // Örneğin dersekle formunda ders adı seçilince, bu veriyi alarak geçiş yapıyoruz.
            string secilenDers = "Örnek Ders"; // Bu kısmı dersekle formundan alınacak dersle güncelleyin.

            // Derslerim formuna, kullanıcı adı ve seçilen ders bilgisini aktarıyoruz
            derslerim derslerimForm = new derslerim(kullaniciAdi, secilenDers);
            derslerimForm.Show();
            this.Hide();
        }

        private void pnl_profil_Click(object sender, EventArgs e)
        {
            profil profilForm = new profil(kullaniciAdi);  // Kullanıcı adı iletildi
            profilForm.Show();
            this.Hide();
        }
    }
}
