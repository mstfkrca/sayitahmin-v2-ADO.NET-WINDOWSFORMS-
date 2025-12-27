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

![Oyun Ekranı](https://github.com/user-attachments/assets/fb7112ff-aebc-4d85-906c-dd8625758967)

### 2. Giriş Ekranı
Kullanıcıların oyuna erişmek için kullandığı güvenli giriş paneli.

![Giriş Ekranı](https://github.com/user-attachments/assets/f9bf49f5-dcb8-4a29-a0b0-9f73d62b8e0e)

### 3. Kayıt Ekranı
Yeni kullanıcıların sisteme dahil olduğu form ekranı.

![Kayıt Ekranı](https://github.com/user-attachments/assets/20d733a3-b8ea-48b0-a2d2-1db61fae8d68)

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

 ## 🗄️ Veritabanı SQL Scriptleri

Projenin çalışması için gerekli tabloları oluşturmak adına, SQL Server Management Studio'da (SSMS) `New Query` diyerek aşağıdaki kodları çalıştırınız.

```sql
USE [master]
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SayiTahminDB')
BEGIN
    CREATE DATABASE [SayiTahminDB]
END
GO

USE [SayiTahminDB]
GO

/****** 1. TABLO: Tbl_Users (Kullanıcılar) ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](256) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Telefon] [nvarchar](15) NULL,
	[Eposta] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** 2. TABLO: Tbl_Scores (Skorlar) ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Scores](
	[ScoreID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Puan] [int] NULL,
	[SureSaniye] [int] NULL,
	[BasamakSayisi] [tinyint] NULL,
	[OyunTarihi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ScoreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tbl_Scores] ADD  DEFAULT ((0)) FOR [Puan]
GO

ALTER TABLE [dbo].[Tbl_Scores] ADD  DEFAULT (getdate()) FOR [OyunTarihi]
GO

ALTER TABLE [dbo].[Tbl_Scores]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Tbl_Users] ([UserID])
GO

