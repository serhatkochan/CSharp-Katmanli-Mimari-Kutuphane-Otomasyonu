using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BaseDAO 
    {
        // Ana veritabanı erişim sınıfımız.
        // Farklı veritabanlarını bu sınıf ile kalıtım aldırıp, 
        // bu metotların içlerini veritabanları için oluşturduğumuz sınıflarda dolduracağız.
        // Böyellikle veri tabanı değişikliği için büyük değişiklikler yapmadan veritabanını değiştirebiliriz.

        private String connectionString; // bağlantı stringimiz için değişken oluşturduk
        public BaseDAO(String connectionString)
        {
            this.connectionString = connectionString; // bağlantı stringimizi constructor yardımıyla alıyoruz.
        }

        // Buradaki metotları method overriding yapabilmek için virtual tanımlıyoruz ve içerisinde bi işlem yapmacağımız için boş bırakıyoruz.



        ///////////// Veritabanı Öğrenci Tablosu Methotları /////////////

        // öğrenci ekleme işlemini yapacak methot 
        public virtual void ogrenci_ekle(String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet) // ekleme metodumuz
        {
            
        }
        // öğrenci silme işlemini yapacak methot
        public virtual void ogrenci_sil(int ogrenci_id)
        {

        }
        // öğrenci güncelleme işlemini yapacak methot
        public virtual void ogrenci_guncelle(int ogrenci_id, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {

        }
        // öğrenci bilgilerini alıp listeleyeceğimiz methot
        public virtual DataSet ogrenci_listele()
        {
            return null;
        }
        // öğrenciyi adı veya tc numarası ile arama işlemini yapacak methot
        public virtual DataSet ogrenci_ara(String adi_veya_tcNo)
        {
            return null;
        }
        // öğrenci ekleme işlemi sırasında kontrol servislerimiz yardımıyla bu tc numarasına ait öğrenci var mı diyebiliriz.
        public virtual Boolean ogrenci_varMi_tcNo(String ogrenci_tcNo)
        {
            return true;
        }
        // -- bu okul numarasına ait öğrenci var mı diyebiliriz duruma göre // kontrol servislerde.
        public virtual Boolean ogrenci_varMi_okulNo(String ogrenci_okulNo)
        {
            return true;
        }



        ///////////// Veritabanı Kitaplar Tablosu Methotları /////////////

        // kitap ekleme metodu
        public virtual void kitap_ekle(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {

        }
        // kitap güncelleme metodu
        public virtual void kitap_guncelle(int kitap_id, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {

        }
        // kitap listeleme metodu
        public virtual DataSet kitap_listele()
        {
            return null;
        }
        // kitap id veya kitap ismi ile arama yapacak methot
        public virtual DataSet kitap_ara(String id_veya_adi)
        {
            return null;
        }
        // eğer bütün kitap parametrelerine uyan kitap zaten var ise ekleme işlemi sırasında kontrol yapacağımız methot
        public virtual Boolean kitap_varMi(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi)
        {
            return true;
        }
        // kitap_id si ile kitabı silecek methot
        public virtual void kitap_sil(int kitap_id)
        {

        }
        // odunc tablosunda bu kita var mı diye kontrol sağlayabileceğimiz methot // varsa ya silmeyecez ya da iki tablodan da silecez
        public virtual Boolean odunc_kitap_varMi(int kitap_id) // kitap silerken bu kitap odunc listesinde var mı diye kontrol edecek.
        {
            return true;
        }
        // odunc tablosunda bu ogrenci var mı diye kontrol edecek methot // varsa silmeyecegiz  ya da iki tablodan da sileceğiz
        public virtual Boolean odunc_ogrenci_varMi(int ogrenci_id) // ogrenci silerken bu  ogrenci odunc listesinde var mı diye kotnrol edecek.
        {
            return true;
        }
        public virtual Boolean kitap_sayisi_kontrolEt(int kitap_id)
        {
            return true;
        }



        ///////////// Veritabanı Odunc Tablosu Methotları /////////////

        // odgrenci_id ve kitap_id ile odunc verme işlemleri yapılacak. Ekstradan odunc alma tarihini gonderecegiz
        public virtual void odunc_ekle(int ogrenci_id, int kitap_id, String odunc_alma_tarihi)
        {

        }
        // odunc tablosundaki butun odunc alınanları gostereceğimiz methot
        public virtual DataSet odunc_listele()
        {
            return null;
        }
        // eger kitabı iade edeceksek teslim tarihini iade edilen tarih yapacağımız methot
        public virtual void odunc_teslim_tarihi_guncelle(int odunc_id, String odunc_teslim_tarihi)
        {

        }
        // Ogrenci tablosundaki ogrencinin borcunu guncelleyeceğimiz methot // kitap iade veya alma işlemlerinde + guncel borc icin
        public virtual void ogrenci_borc_guncelle(int ogrenci_id, int ogrenci_borc)
        {

        }
        // Odunc tablosundaki ogrencinin borcunu guncelleyecegimiz methot // kitap iade veya alma işlemlerinde + guncel borc icin
        public virtual void odunc_ogrenci_borc_guncelle(int ogrenci_id, int odunc_ogrenci_borc)
        {

        }
        // eger kitap iade ediliyorsa Kitaplar tablosundaki kitap_adeti 1 artacak.
        public virtual void odunc_kitap_adet_arttir(int kitap_id)
        {

        }
        // eger kitap odunc aliniyorsa Kitaplar tablosundaki kitap_adeti 1 azalacak.
        public virtual void odunc_kitap_adet_azalt(int kitap_id)
        {

        }
        // ogrencinin odunc aldigi bütün kitapalrı listeler
        public virtual DataSet odunc_ogrenci_listele(int ogrenci_id)
        {
            return null;
        }
        // bu kitabı hangi ogrenciler aldıysa hepsini listeler
        public virtual DataSet odunc_kitap_listele(int kitap_id)
        {
            return null;
        }
        // eğer ogrencinin hali hazırda teslim edilmemiş bir kitabı varsa öğrenciye yeni bir ödünç kitap vermeyeceğiz
        public virtual Boolean odunc_teslim_edildiMi(int ogrenci_id)
        {
            return true;
        }
        // bu kitabı teslim etmeyen öğrenci var mı bilgisi
        public virtual Boolean odunc_kitap_teslim_edildiMi(int kitap_id)
        {
            return true;
        }
        // secili odunc_id ye ait ödünç bilgisi teslim edilmiş mi 
        public virtual Boolean odunc_id_teslim_edildiMi(int odunc_id)
        {
            return true;
        }
        // eğer öğrenci kitabı teslim etmediyse öğrencinin gecikme süresini hesaplayacağız
        public virtual int odunc_teslim_zaman_kontrol(int odunc_id)
        {
            return 0;
        }
        // ödünç tablosundan öğrenciyi siliyoruz
        public virtual void odunc_ogrenci_sil(int ogrenci_id)
        {

        }
        // ödünç tablosundan kitabı siliyoruz
        public virtual void odunc_kitap_sil(int kitap_id)
        {

        }
        // ödünç tablosunda arama işlemi yapıyoruz
        public virtual DataSet odunc_ara(String id_ad_isim)
        {
            return null;
        }



        ///////////// Sayma ve Zedgraph İşlemleri İçin Methotlar /////////////

        // Kitaplar tablosundaki toplam kitap sayısını alacağız
        public virtual int kitap_sayisi()
        {
            return 0;
        }
        public virtual int ogrenci_sayisi()
        {
            return 0;
        }
        // Odunc tablosundaki toplam odunc alınan kitap sayısını alacağız
        public virtual int odunc_alinan_kitap_sayisi()
        {
            return 0;
        }
        // Odunc tablosundaki teslim edilmeyen kitap sayısını alacağız
        public virtual int odunc_teslim_edilmeyen_kitap_sayisi()
        {
            return 0;
        }
        // öğrencinin kaç tane ödünç kitap aldığını sayacak.
        public virtual int odunc_ogrenci_kitap_sayisi(int ogrenci_id)
        {
            return 0;
        }// kitabın kaç tane öğrenciye verildiğinin sayısını döndürecek.
        public virtual int odunc_kitap_ogrenci_sayisi(int kitap_id)
        {
            return 0;
        }

    }
}
