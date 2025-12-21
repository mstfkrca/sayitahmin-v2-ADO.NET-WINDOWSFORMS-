using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace sayitahmin_v2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // sql baðlantýsý
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LTFP1SNI\SQLEXPRESS;Initial Catalog=SayiTahminDB;Integrated Security=True;TrustServerCertificate=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                //Þifreyi güvenlik kontrolünden geçirip (hashleyip) öyle soruyoruz.
                // Çünkü veritabanýnda þifre "1234" diye deðil, karmaþýk kod olarak duruyor.
                string sifreliGiris = Guvenlik.Sha256Yap(txtSifre.Text);

                SqlCommand komut = new SqlCommand("Select UserID, Ad, Soyad From Tbl_Users where KullaniciAdi=@p1 and Sifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", sifreliGiris); // Þifreli hali gönderdik

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    // --- GÝRÝÞ BAÞARILI ---
                    string adSoyad = dr["Ad"] + " " + dr["Soyad"];
                    MessageBox.Show("Hoþ geldin " + adSoyad, "Giriþ Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmOyun fr = new FrmOyun();
                    fr.mevcutKullaniciID = Convert.ToInt32(dr["UserID"]); // ID transferi
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý Hatasý: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        //KAYIT OL BUTONUNA TIKLANINCA

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayit fr = new FrmKayit();
            fr.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {
            FrmKayit fr = new FrmKayit(); // Kayýt formunu oluþtur
            fr.Show();                    // Formu göster
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}