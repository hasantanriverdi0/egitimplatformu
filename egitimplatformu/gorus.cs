using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egitimplatformu
{
    public partial class gorus : Form
    {
        public gorus()
        {
            InitializeComponent();
        }
        string kullanici = "";
        private void panel1_Click(object sender, EventArgs e)
        {
            string girilenMetin = richTextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(girilenMetin))
            {
                MessageBox.Show("Lütfen bir metin giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (girilenMetin.Length < 20)
            {
                MessageBox.Show("Lütfen en az 20 karakter giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Talebiniz iletilmiştir. Desteğiniz için teşekkür ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Clear();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfaForm = new anasayfa(kullanici);  // doğru kullanıcı adını geçiyoruz
            anasayfaForm.Show();
            this.Hide();
        }

        private void gorus_Load(object sender, EventArgs e)
        {

        }
    }
}