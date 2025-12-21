using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace sayitahmin_v2
{
    public partial class FrmOyun : Form
    {
        public FrmOyun()
        {
            InitializeComponent();
        }

        public int mevcutKullaniciID; // Login'den gelen ID

        // OYUN DEĞİŞKENLERİ
        int saniye = 0;
        string hedefSayiStr = "";
        int tahminHakki = 10;
        int puan = 100;
        int secilenBasamak = 3;
        Random rnd = new Random();

        // SQL Bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LTFP1SNI\SQLEXPRESS;Initial Catalog=SayiTahminDB;Integrated Security=True;TrustServerCertificate=True");

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            // Başlangıç Ayarları
            btnTahmin.Enabled = false;
            txtTahmin.Enabled = false; // Klavyeden yazmayı engelleyip sadece buton kullandırtabiliriz
            txtTahmin.ReadOnly = false; // Sadece sanal klavye işlesin istiyorsan bunu aç
            flowGecmis.Controls.Clear();

            if (cmbBasamak.Items.Count == 0)
            {
                cmbBasamak.Items.Add("3");
                cmbBasamak.Items.Add("4");
                cmbBasamak.Items.Add("5");
                cmbBasamak.SelectedIndex = 0;
            }

            // En iyi 5 skoru listele
            SkorlariListele();
        }

        // --- SKORLARI LİSTELEME METODU ---
        void SkorlariListele()
        {
            try
            {
                lstSkorlar.Items.Clear();
                baglanti.Open();
                // Puanı en yüksek olan ilk 5 kişiyi çekiyoruz. Kullanıcı adını görmek için JOIN yaptık.
                SqlCommand komut = new SqlCommand("SELECT TOP 5 Tbl_Users.Ad, Tbl_Scores.Puan FROM Tbl_Scores INNER JOIN Tbl_Users ON Tbl_Scores.UserID = Tbl_Users.UserID ORDER BY Puan DESC", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    lstSkorlar.Items.Add(dr[0] + " - " + dr[1] + " Puan");
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                // Hata olursa sessizce geçebilir veya mesaj verebiliriz
            }
        }

        // --- SKOR KAYDETME METODU ---
        void SkorKaydet()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Scores (UserID, Puan, SureSaniye, BasamakSayisi, OyunTarihi) VALUES (@p1, @p2, @p3, @p4, @p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", mevcutKullaniciID);
                komut.Parameters.AddWithValue("@p2", puan);
                komut.Parameters.AddWithValue("@p3", saniye); // Global saniye değişkeni
                komut.Parameters.AddWithValue("@p4", secilenBasamak);
                komut.Parameters.AddWithValue("@p5", DateTime.Now);
                komut.ExecuteNonQuery();
                baglanti.Close();

                // Listeyi güncelle ki adımız hemen görünsün
                SkorlariListele();
            }
            catch (Exception ex)
            {
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Skor kaydedilemedi: " + ex.Message);
            }
        }

        // --- SANAL KLAVYE OLAYLARI ---
        // Bu metodu tüm rakam butonlarına (btn0...btn9) bağlayacağız!
        private void RakamButon_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Length < secilenBasamak)
            {
                Button tiklanan = (Button)sender;
                txtTahmin.Text += tiklanan.Text;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Length > 0)
            {
                txtTahmin.Text = txtTahmin.Text.Substring(0, txtTahmin.Text.Length - 1);
            }
        }

        // --- OYUNU BAŞLAT ---
        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBasamak.Text)) return;

            secilenBasamak = Convert.ToInt32(cmbBasamak.Text);

            int min = 0, max = 0;
            if (secilenBasamak == 3) { min = 100; max = 1000; }
            else if (secilenBasamak == 4) { min = 1000; max = 10000; }
            else if (secilenBasamak == 5) { min = 10000; max = 100000; }

            hedefSayiStr = rnd.Next(min, max).ToString();

            txtTahmin.MaxLength = secilenBasamak;
            tahminHakki = 10;
            puan = 100;
            saniye = 0; // Süreyi sıfırla
            flowGecmis.Controls.Clear();

            lblDurum.Text = "Kalan Hak: " + tahminHakki;
            lblDurum.ForeColor = Color.Black;
            lblPuan.Text = "Puan: 100";

            txtTahmin.Text = "";
            txtTahmin.Enabled = true;
            btnTahmin.Enabled = true;
            btnBasla.Enabled = false;
            cmbBasamak.Enabled = false;

            timer1.Start();
        }

        // --- TAHMİN ET ---
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text;

            if (tahmin.Length != secilenBasamak)
            {
                MessageBox.Show($"Lütfen {secilenBasamak} haneli bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Renklendirme Mantığı
            Color[] renkler = new Color[secilenBasamak];
            bool[] hedefKullanildi = new bool[secilenBasamak];
            bool[] tahminIsletildi = new bool[secilenBasamak];

            for (int i = 0; i < secilenBasamak; i++) renkler[i] = Color.Gray;

            //başlangıçta tüm basamaklar gridir 1. tur sadece yeşilleri yakalar
            //2.turda ise yeşiller tekrar kontrole girmez sadece turuncu kontorlü yapılır

            // 1. TUR: YEŞİL
            for (int i = 0; i < secilenBasamak; i++)
            {
                if (tahmin[i] == hedefSayiStr[i])
                {
                    renkler[i] = Color.Green;
                    hedefKullanildi[i] = true; //aynı sayı turuncu boyanmasın diye true
                    tahminIsletildi[i] = true; 
                }
            }

            // 2. TUR: TURUNCU
            for (int i = 0; i < secilenBasamak; i++)
            {
                if (!tahminIsletildi[i])// yeşil olmayanlar için
                {
                    for (int j = 0; j < secilenBasamak; j++)
                    {
                        if (!hedefKullanildi[j] && tahmin[i] == hedefSayiStr[j]) //hedefte kullanılmamışsa ve tahmindeki rakam hedefte varsa
                        {
                            renkler[i] = Color.Orange;
                            hedefKullanildi[j] = true;
                            break;
                        }
                    }
                }
            }

            TahminiEkranaEkle(tahmin, renkler);

            if (tahmin == hedefSayiStr)
            {
                OyunBitti(true);
            }
            else
            {
                tahminHakki--;
                puan -= 10;
                lblDurum.Text = "Kalan Hak: " + tahminHakki;
                lblPuan.Text = "Puan: " + puan;

                if (tahminHakki <= 0)
                {
                    lblDurum.Text = "HEDEF: " + hedefSayiStr;
                    OyunBitti(false);
                }
                else
                {
                    txtTahmin.Text = "";
                }
            }
        }

        private void TahminiEkranaEkle(string tahminStr, Color[] renkler)
        {
            Panel satirPanel = new Panel();
            satirPanel.Size = new Size((secilenBasamak * 40) + 20, 40);
            satirPanel.Margin = new Padding(3);

            for (int i = 0; i < secilenBasamak; i++)
            {
                Label kutu = new Label();
                kutu.Text = tahminStr[i].ToString();
                kutu.BackColor = renkler[i];
                kutu.ForeColor = Color.White;
                kutu.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                kutu.TextAlign = ContentAlignment.MiddleCenter;
                kutu.Size = new Size(35, 35);
                kutu.Location = new Point(i * 40, 0);
                satirPanel.Controls.Add(kutu);
            }

            flowGecmis.Controls.Add(satirPanel);
            flowGecmis.ScrollControlIntoView(satirPanel);
        }

        private void OyunBitti(bool kazandi)
        {
            timer1.Stop();
            btnTahmin.Enabled = false;
            btnBasla.Enabled = true;
            cmbBasamak.Enabled = true;

            if (kazandi)
            {
                MessageBox.Show($"TEBRİKLER! Sayıyı buldunuz.\nPuanınız: {puan}", "ŞAMPİYON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SkorKaydet(); //Veritabanına yazıyor.
            }
            else
            {
                MessageBox.Show($"Maalesef hakkınız bitti. Sayı: {hedefSayiStr}", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSure.Text = saniye.ToString();
        }

        private void cmbBasamak_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            txtTahmin.Clear();
        }

        private void flowGecmis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bu komut, btnTahmin butonuna sanal olarak tıklar.
            // Böylece btnTahmin içindeki tüm kodlar çalışır.
            btnTahmin.PerformClick();
        }
    }
}