using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace egitimplatformu
{
    public partial class derslerim : Form
    {
        private string kullaniciAdi;  // Kullanıcı adı
        private string secilenDers;  // Seçilen ders

        // Parametreli constructor
        public derslerim(string kullanici, string ders)
        {
            InitializeComponent();
            kullaniciAdi = kullanici;  // Kullanıcı adı
            secilenDers = ders;  // Seçilen ders
        }

        private void LoadDersler()
        {
            // Dersler.txt dosyasından dersleri yükleme
            if (File.Exists("dersler.txt"))
            {
                string[] dersler = File.ReadAllLines("dersler.txt");
                foreach (string ders in dersler)
                {
                    listBox1.Items.Add(ders);  // Her dersi listBox'a ekliyoruz
                }
            }
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            // Geri butonuna tıklandığında kullanıcı adıyla anasayfaya dönülür
            anasayfa anasayfaForm = new anasayfa(kullaniciAdi);  // Kullanıcı adıyla anasayfa açılır
            anasayfaForm.Show();
            this.Hide();  // Bu form gizlenir
        }

        public int GetDersSayisi()
        {
            return listBox1.Items.Count;  // ListBox'taki öğe sayısını döndürüyoruz
        }

        private void derslerim_Load(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;

            // Dersler.txt dosyasındaki dersleri yüklemek
            LoadDersler();  // Dersleri yüklemek için LoadDersler metodunu çağırıyoruz
        }

        private void pnl_sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilenDers = listBox1.SelectedItem.ToString();  // Seçilen dersi alıyoruz

                // Dersler.txt dosyasındaki dersleri okuyoruz
                List<string> dersler = File.ReadAllLines("dersler.txt").ToList();

                // Seçilen dersi dersler listesinde buluyoruz ve siliyoruz
                dersler.Remove(secilenDers);

                // Güncellenmiş listeyi tekrar dersler.txt dosyasına yazıyoruz
                File.WriteAllLines("dersler.txt", dersler);

                // ListBox'tan da siliniyor
                listBox1.Items.Remove(secilenDers);

                MessageBox.Show("Ders başarıyla silindi!");
            }
            else
            {
                MessageBox.Show("Lütfen bir ders seçin.");
            }
        }
    }
}
