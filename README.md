# LibraryManagementSystem_2
# 📚 Kütüphane Otomasyon Sistemi

Bu proje, C# Windows Forms ve SQL Server kullanılarak geliştirilmiş kapsamlı bir Kütüphane Yönetim ve Otomasyon Sistemidir. Kullanıcı dostu arayüzü sayesinde kitap, üye, yazar ve kategori yönetimini kolaylaştırırken, ödünç alma ve iade işlemlerini anlık olarak takip etmeyi sağlar.

## 🚀 Proje Hakkında ve Geliştirme Süreci

Yönetim Bilişim Sistemleri (YBS) 1. sınıf öğrencisi olarak C# ve SQL öğrenme serüvenimin önemli bir parçası olan bu projeyi, Murat Yücedağ'ın eğitimlerinden ilham alarak geliştirdim. 

Modern bir yazılımcının en büyük araçlarından birinin yapay zeka olduğunun bilinciyle, bu projeyi geliştirirken mimari kurguyu oturtmak, LINQ sorgularını optimize etmek ve takıldığım hataları (örneğin WinForms arayüz yönlendirmeleri) çözmek için **Google Gemini** yapay zeka asistanından destek aldım. Bu sayede hem kodlama pratiğimi geliştirdim hem de yapay zeka ile pair-programming (eşli programlama) yapma deneyimi kazandım.

## 🛠️ Temel Özellikler

* **Gösterge Paneli (Dashboard):** Sistemdeki toplam kitap, üye, ödünç verilen kitap ve geciken işlem sayılarını anlık olarak gösterir. Son yapılan işlemleri listeler.
* **İşlem Yönetimi:** Üyelere kitap ödünç verme, süre takibi yapma ve iade alma işlemleri.
* **Kitap ve Yazar Yönetimi:** Yeni kitap/yazar ekleme, silme, güncelleme ve sayfa sayısı/kategori bazlı listeleme.
* **Üye Yönetimi:** Kütüphane üyelerinin iletişim bilgileriyle beraber sisteme kaydedilmesi ve takibi.
* **Kategori Yönetimi:** Kitap türlerinin dinamik olarak yönetilmesi.

## 💻 Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (.NET)
* **Veritabanı:** MS SQL Server
* **Veri Erişimi:** Entity Framework / LINQ

## 📸 Ekran Görüntüleri

| Gösterge Paneli | İşlemler Formu |
| :---: | :---: |
| ![Dashboard](<img width="1285" height="733" alt="Ekran görüntüsü 2026-02-21 133530" src="https://github.com/user-attachments/assets/366b3135-fc58-4bbb-bf11-03558b966895" />
) | ![Islemler](<img width="1285" height="730" alt="Ekran görüntüsü 2026-02-21 133834" src="https://github.com/user-attachments/assets/12ddb809-bb6d-4761-9462-a4d4415ebc84" />
) |

| Kitaplar Formu | Üyeler Formu |
| :---: | :---: |
| ![Kitaplar](<img width="1452" height="732" alt="Ekran görüntüsü 2026-02-21 134112" src="https://github.com/user-attachments/assets/cdd18550-0061-405c-a6d7-d154b871af80" />
) | ![Uyeler](<img width="1288" height="726" alt="Ekran görüntüsü 2026-02-21 133630" src="https://github.com/user-attachments/assets/9a758303-4d9a-49b1-b8a0-4804f10d5472" />
) |

| Yazarlar Formu | Kategoriler Formu |
| :---: | :---: |
| ![Yazarlar](<img width="1286" height="727" alt="Ekran görüntüsü 2026-02-21 133806" src="https://github.com/user-attachments/assets/f2541d9f-8abd-4ecd-8fa0-3c3c6f517b2e" />) | ![Kategoriler](<img width="1282" height="728" alt="Ekran görüntüsü 2026-02-21 133728" src="https://github.com/user-attachments/assets/72d79859-b3d9-433b-9ed1-85bb03ce532a" />
) |

## ⚙️ Kurulum ve Çalıştırma

Projeyi kendi bilgisayarınızda test etmek için aşağıdaki adımları izleyebilirsiniz:

1. Bu repoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/KULLANICI_ADIN/KutuphaneOtomasyonu.git](https://github.com/KULLANICI_ADIN/KutuphaneOtomasyonu.git)
2. Proje klasörü içindeki Database (veya SQL) klasöründe bulunan .sql script dosyasını SQL Server Management Studio (SSMS) üzerinden çalıştırarak veritabanını (örnek verilerle birlikte) oluşturun.

3. Visual Studio'da .sln dosyasını açın.

4. Context (veya App.config) dosyanızdaki SQL Server Connection String (Bağlantı Cümlesi) kısmını kendi yerel sunucu adınıza göre güncelleyin.

5. Projeyi derleyip (Build) çalıştırın.
