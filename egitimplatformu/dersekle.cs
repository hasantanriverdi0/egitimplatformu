using System;
using System.IO;
using System.Windows.Forms;

namespace egitimplatformu
{
    public partial class dersekle : Form
    {
        private string kullaniciAdi;

        public dersekle(string ad)
        {
            InitializeComponent();
            kullaniciAdi = ad;  // Kullanıcı adı sınıf değişkenine atanıyor
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfaForm = new anasayfa(kullaniciAdi);  // Giriş yapan kullanıcı adı ile anasayfa formu oluşturuluyor
            anasayfaForm.Show();
            this.Hide();  // Bu formu gizliyoruz
        }

        private void dersekle_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Dersleri ListBox'a ekleyelim
            foreach (var ders in DersListesi.Dersler)
            {
                listBox1.Items.Add(ders.ToString());
            }
        }

        private void pnl_kayit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilenDers = listBox1.SelectedItem.ToString();  // Seçilen ders alınıyor
                string dersKaydi = "Öğrenci: " + kullaniciAdi + ", Ders: " + secilenDers;  // Öğrenci adı ve ders bilgisi birleştiriliyor

                // Ders kaydını dersler.txt dosyasına ekliyoruz
                File.AppendAllText("dersler.txt", dersKaydi + Environment.NewLine);  // Yeni ders bilgisi ekleniyor

                MessageBox.Show("Ders başarıyla kaydedildi!");  // Kullanıcıya başarılı mesajı gösteriliyor
            }
            else
            {
                MessageBox.Show("Lütfen bir ders seçiniz!");  // Ders seçilmediğinde uyarı mesajı
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
