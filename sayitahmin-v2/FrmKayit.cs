using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // SQL kütüphanesi

namespace sayitahmin_v2
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        // sql bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LTFP1SNI\SQLEXPRESS;Initial Catalog=SayiTahminDB;Integrated Security=True;TrustServerCertificate=True");

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                //Boş alan kontrolü
                if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı ve şifre zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();

                //Kullanıcı adı daha önce alınmış mı kontrolü
                SqlCommand kontrolKomut = new SqlCommand("Select Count(*) From Tbl_Users where KullaniciAdi=@p1", baglanti);
                kontrolKomut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Başka bir tane seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    return;
                }

                //Kayıt işlemi (Şifreleme Dahil)
                string sorgu = "INSERT INTO Tbl_Users (Ad, Soyad, KullaniciAdi, Sifre, Telefon, Eposta) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);

                //Şifre hashing
                string sifreliSifre = Guvenlik.Sha256Yap(txtSifre.Text);
                komut.Parameters.AddWithValue("@p4", sifreliSifre);
                

                komut.Parameters.AddWithValue("@p5", txtTelefon.Text);
                komut.Parameters.AddWithValue("@p6", txtEposta.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı! Şimdi giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt formunu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
            }
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}