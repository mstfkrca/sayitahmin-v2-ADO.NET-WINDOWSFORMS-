# 🎮 Sayı Tahmin Oyunu (Number Guessing Game)

Bu proje, C# Windows Forms ve MSSQL veritabanı kullanılarak geliştirilmiş, kullanıcı girişli ve skor takipli gelişmiş bir sayı tahmin oyunudur. "Wordle" veya "Mastermind" oyunlarının sayı tabanlı mantığı ile çalışır.

## 📋 Proje Hakkında

Kullanıcıların sisteme kayıt olup giriş yaptıktan sonra, seçtikleri basamak sayısına (3, 4 veya 5) göre bilgisayarın tuttuğu rastgele sayıyı tahmin etmeye çalıştıkları bir uygulamadır. Oyun, kullanıcının tahminlerine göre renkli ipuçları vererek doğru sayıya ulaşmasını sağlar.

## 🚀 Özellikler

* **🔐 Güvenli Kullanıcı Sistemi:**
    * Kullanıcı Kayıt ve Giriş ekranları.
    * **SHA-256 Şifreleme:** Kullanıcı şifreleri veritabanında düz metin olarak değil, hash'lenmiş (şifrelenmiş) olarak saklanır.
* **🎮 Dinamik Oyun Yapısı:**
    * 3, 4 veya 5 basamaklı sayı tahmin seçenekleri.
    * Sanal Klavye desteği.
    * Anlık geri bildirim sistemi (Renklendirme mantığı).
* **📊 Skor Tablosu:**
    * MSSQL veritabanı entegrasyonu.
    * En yüksek puanı alan "En İyi 5 Oyuncu" listesi.
    * Puanlama sistemi (Kalan hak, süre ve basamak sayısına göre).

## 🎨 Ekran Görüntüleri

### 1. Oyun Ekranı
Oyunun ana arayüzü. Kullanıcı tahminlerini yapar, renkli ipuçlarını görür ve skor tablosunu takip eder.
* **Yeşil:** Sayı var ve yeri doğru.
* **Turuncu:** Sayı var ama yeri yanlış.
* **Gri:** Sayı yok.

![Oyun Ekranı](screenshots/oyun_ekrani.png)
*(Buraya oyun ekranı görüntüsü gelecek - Ekran görüntüsü 2025-12-21 161706.png)*

### 2. Giriş Ekranı
Kullanıcıların oyuna erişmek için kullandığı güvenli giriş paneli.

![Giriş Ekranı](screenshots/giris_ekrani.png)
*(Buraya giriş ekranı görüntüsü gelecek - Ekran görüntüsü 2025-12-21 182439.png)*

### 3. Kayıt Ekranı
Yeni kullanıcıların sisteme dahil olduğu form ekranı.

![Kayıt Ekranı](screenshots/kayit_ekrani.png)
*(Buraya kayıt ekranı görüntüsü gelecek - Ekran görüntüsü 2025-12-21 182548.png)*

## 🛠 Kullanılan Teknolojiler

* **Dil:** C# (.NET Framework / Windows Forms)
* **Veritabanı:** Microsoft SQL Server (MSSQL)
* **Veri Erişimi:** ADO.NET (System.Data.SqlClient)
* **Güvenlik:** System.Security.Cryptography (SHA256)

## ⚙️ Kurulum ve Çalıştırma

1.  Bu projeyi bilgisayarınıza klonlayın veya indirin.
2.  **Veritabanı Kurulumu:**
    * MSSQL üzerinde `SayiTahminDB` adında bir veritabanı oluşturun.
    * `Tbl_Users` ve `Tbl_Scores` tablolarını oluşturun (SQL Scriptleri proje dosyalarında mevcuttur).
3.  **Bağlantı Ayarı:**
    * Proje içerisindeki `SqlConnection` satırını kendi bilgisayarınızın sunucu ismine göre güncelleyin:
    ```csharp
    @"Data Source=BILGISAYAR_ADINIZ\SQLEXPRESS;Initial Catalog=SayiTahminDB;Integrated Security=True"
    ```
4.  Visual Studio üzerinden projeyi başlatın (`F5`).

## 📝 Oyun Kuralları

1.  Zorluk seviyesini (Basamak sayısı) seçin ve **"Oyunu Başlat"** butonuna basın.
2.  Tahmininizi klavyeden veya ekrandaki tuş takımından girin.
3.  **Yeşil kutu:** Rakamı doğru yere koydunuz.
4.  **Turuncu kutu:** Rakam sayıda var ama yeri yanlış.
5.  Toplam 10 tahmin hakkınız vardır. En kısa sürede ve en az denemede bilmek daha yüksek puan kazandırır!

---
**Geliştirici:** [Adınız Soyadınız]