using System;
using System.Security.Cryptography; // Şifreleme kütüphanesi
using System.Text;

namespace sayitahmin_v2
{
    public static class Guvenlik
    {
        // Bu metod, içine atılan şifreyi (örn: "1234") alır
        // Geriye karmaşık, çözülemez bir kod (Hash) döndürür.
        public static string Sha256Yap(string rawData)
        {
            // SHA256 algoritmasını başlat
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Veriyi byte dizisine çevir ve hashle
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Byte dizisini string'e (yazıya) çevir
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}