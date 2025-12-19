using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // SQL kütüphanesini buraya da ekleyelim, lazım olacak.

// DÜZELTME 1: Namespace ismini Login formuyla aynı yaptık (sayitahmin_v2)
namespace FrmOyun
{
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
        }

        // DÜZELTME 2: Login formundan gelen ID'yi burada tutacağız
        public int mevcutKullaniciID;

        // Global Değişkenler
        Random rnd = new Random();
        int hedefSayi = 0;
        int saniye = 0;
        int puan = 100;
        int basamak = 0;

        // --- SQL BAĞLANTISI (Skor kaydetmek için hazırlık) ---
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=SayiTahminDB;Integrated Security=True;TrustServerCertificate=True");

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBasamak.Text))
            {
                MessageBox.Show("Lütfen basamak sayısı seçin!");
                return;
            }

            basamak = Convert.ToInt32(cmbBasamak.Text);

            if (basamak == 3) hedefSayi = rnd.Next(100, 1000);
            else if (basamak == 4) hedefSayi = rnd.Next(1000, 10000);
            else if (basamak == 5) hedefSayi = rnd.Next(10000, 100000);

            saniye = 0;
            puan = 100;
            lblPuan.Text = "Puan: " + puan;
            lblSure.Text = "0";
            lblDurum.Text = "Sayı Tutuldu! Tahminini Yap.";
            lblDurum.ForeColor = Color.Black;
            txtTahmin.Text = "";

            btnTahmin.Enabled = true;
            cmbBasamak.Enabled = false;
            btnBasla.Enabled = false;

            timer1.Start();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmin;
            if (!int.TryParse(txtTahmin.Text, out tahmin))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
                return;
            }

            if (tahmin == hedefSayi)
            {
                timer1.Stop();
                lblDurum.Text = "TEBRİKLER! BULDUNUZ.";
                lblDurum.ForeColor = Color.Green;
                btnTahmin.Enabled = false;
                btnBasla.Enabled = true;
                cmbBasamak.Enabled = true;

                MessageBox.Show($"Tebrikler! {saniye} saniyede bildiniz. Puanınız: {puan}");

                // --- BURADA SKORU VERİTABANINA KAYDEDECEĞİZ (Bir sonraki adım) ---
                // KaydetSkor(); 
            }
            else
            {
                puan -= 10;
                lblPuan.Text = "Puan: " + puan;

                if (tahmin < hedefSayi)
                {
                    lblDurum.Text = "Daha BÜYÜK bir sayı gir ▲";
                    lblDurum.ForeColor = Color.Red;
                }
                else
                {
                    lblDurum.Text = "Daha KÜÇÜK bir sayı gir ▼";
                    lblDurum.ForeColor = Color.Blue;
                }
                txtTahmin.Focus();
                txtTahmin.SelectAll();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSure.Text = saniye.ToString();
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            // Kontrol: ID gelmiş mi bakalım?
            // this.Text = "Oynayan ID: " + mevcutKullaniciID; // Test için başlığa yazdırabiliriz

            if (cmbBasamak.Items.Count > 0)
                cmbBasamak.SelectedIndex = 0;

            btnTahmin.Enabled = false;
        }

        private void cmbBasamak_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Boş kalsın, Designer hatası olmasın diye.
        }
    }
}