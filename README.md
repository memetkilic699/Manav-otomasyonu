# PROJENİN ADI
**Manav otomasyon**

## 1. Projenin Amacı ve Kapsamı

**Amaç:** Manav işletmelerinde tezgah üzerindeki satış işlemlerini hızlandırmak, ürün stoklarını dijital ortamda anlık takip etmek, fiyat/maliyet güncellemelerini kolayca yapmak ve personel yetkilendirmesini tek bir masaüstü uygulamasında toplamak.

**Hedef Kitle:** Manav tezgahtarları (hızlı satış ekranı için) ve işletme yöneticileri/müdürler (ürün yönetimi, stok takibi ve personel işlemleri için).

## 2. Uygulama Mimarisi (Form ve Ekran Yapısı)

Proje, Visual Studio üzerinde Tek Form (Single Form) ve Panel tabanlı mimariyle tasarlanmıştır.. Birbiriyle haberleşen temel modüller şunlardır:

### Giriş ve Yetkilendirme Modülü:

Kullanıcının (Personel, Kasiyer veya Müdür) sisteme kendi şifresi ve rolüyle güvenli şekilde giriş yapmasını sağlar. Rolüne göre hangi ekranlara erişebileceğini belirler.

### Ana Satış Ekranı:

- Sol tarafta ürünlerin kategori bazlı filtrelenebildiği resimli buton kataloğu yer alır.
- Sağ tarafta ise seçilen ürünlerin eklendiği sepet tablosu, ara toplam, KDV ve tek tuşla "Satışı Tamamla" ödeme alanı bulunur.

### Ürün ve Stok Yönetim Paneli:

- Yeni meyve/sebze tanımlama, mevcut ürünün fiyatını veya stok miktarını güncelleme ve listeden çıkarma işlemlerinin yapıldığı alandır.
- Ürünlere ait görsellerin sisteme tanıtıldığı ve kritik stok seviyelerinin renkli uyarılarla takip edildiği bölümdür.

### Personel ve Kullanıcı Yönetim Paneli:

İşletmede çalışan personellerin (Ad Soyad, Görev, Telefon, TC, İşe Başlangıç Tarihi ve vesikalık fotoğrafları ile) sisteme kaydedildiği, yetkilerinin ve iletişim bilgilerinin yönetildiği ekrandır.

## 3. Veritabanı Mimarisi (Tablolar ve İlişkiler)

Veritabanında verilerin düzenli tutulması ve tablolar arası bağların kurulması için şu temel tablolar yer alacaktır:

### Kullanıcılar (Personel) Tablosu:

**İçerdiği Bilgiler:** Personel ID (Benzersiz Numara), Ad Soyad, Kullanıcı Adı, Şifre, Görev (Müdür/Kasiyer/Personel), Telefon, TC Kimlik No, İşe Başlangıç Tarihi ve Fotoğraf Yolu.

**Amaç:** Sisteme kimin giriş yaptığını ve yetkilerini belirlemek.

### Ürünler Tablosu:

**İçerdiği Bilgiler:** Ürün ID, Ürün Adı, Kategori (Meyve/Sebze), Birim Fiyatı, Maliyet Fiyatı, Stok Miktarı (Kg/Adet), Kritik Stok Sınırı ve Ürün Resim Yolu.

**Amaç:** Manavdaki tüm ürünlerin güncel fiyatını, stoğunu ve görsel bilgisini saklamak.

### Satışlar Tablosu:

**İçerdiği Bilgiler:** Satış ID, Satışı Yapan Kullanıcı ID, Toplam Tutar ve Satış Tarihi/Saati.

**Amaç:** Hangi personelin, ne zaman ve toplam ne kadarlık satış yaptığının geçmişini tutmak (Ciro takibi için).

### SatışDetay Tablosu:

**İçerdiği Bilgiler:** Detay ID, Satış ID, Ürün ID, Satılan Miktar (Kg veya Adet) ve Ara Tutar.

**Amaç:** Gerçekleşen bir satış fişinin içinde hangi ürünlerden kaçar kilo alındığını detaylandırmak (Stoktan otomatik düşüm ve raporlama için Satislar ve Urunler tablolarını birbirine bağlar).
