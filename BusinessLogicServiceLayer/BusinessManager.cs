using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicServiceLayer
{
    public class BusinessManager 
    {
        // Bütün program işlemlerini burada yapacağız.
        //Sunum katmanında bu sınıfa erişerek istediğimiz işlemleri yaptıracağız

        ///////////// Sunum katmanında constructor olarak alacağımız servisleri tanımlıyoruz /////////////

        private BaseDAO baseDAO; // İstedigimiz veritabanını new xDAO(connectionString) şeklinde gonderecegiz.
        private StudentCheckService studentCheck;     // 
        private BookCheckService bookCheck;           // oluşturduğumuz kontrol servislerinden kullanacagımızı sunum katmanında gonderecegiz.
        private BorrowedCheckService borrowedCheck;   //



        ///////////// Constructor yardımıyla kullanacagğımız veritabanı ve kontrol servisleri ilişkilendirmelerini yapıyoruz.

        public BusinessManager(BaseDAO baseDAO, StudentCheckService studentCheck, BookCheckService bookCheck, BorrowedCheckService borrowedCheck)
        {
            this.baseDAO = baseDAO;
            this.studentCheck = studentCheck;
            this.bookCheck = bookCheck;
            this.borrowedCheck = borrowedCheck;
        }


        ///////////// Ogrenci işlemlerimiz /////////////
        
        // öğrenci var mı diye ilk once studentCheck den kontrol sağlayacak, varsa true değerini dondurecek ve ekleme işlemi yapmayacak.
        // eğer ogrenci yoksa ekleme işlemini yapacak ve false değerini dondurecek.
        public Boolean ogrenci_ekle(String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            if (studentCheck.checkStudent(baseDAO, ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet))
            {
                return true;
            }
            else
            {
                baseDAO.ogrenci_ekle(ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet);
                return false;
            }

        }
        // öğrenci silineceği zaman borrowedCheck ile odunc tablosu ile kontrol sağlanacak 
        // ve odunc tablosunda öğrenci varsa geriye true dondurecek ve silme işlemi yapmayacak
        // eğer öğrenci yoksa silme işlemini yapacak ve false değerini dondurecek.
        public Boolean ogrenci_sil(int ogrenci_id)
        {
            if (borrowedCheck.borrowedCheck(baseDAO, ogrenci_id, 2))
            {
                return true;
            }
            else
            {
                baseDAO.ogrenci_sil(ogrenci_id);
                return false;
            }
        }
        // verdiğimiz değerlere gore öğrenci bilgileri guncellenecek.
        public Boolean ogrenci_guncelle(int ogrenci_id, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
                baseDAO.ogrenci_guncelle(ogrenci_id, ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet);
                return false;
        }
        // ogrenci_id veya ogrenci_adi ile arama yapacak
        public DataSet ogrenci_ara(String id_veya_adi)
        {
            return baseDAO.ogrenci_ara(id_veya_adi);
        }
        // bütün öğrencileri listeleyecek.
        public DataSet ogrenci_listele()
        {
            return baseDAO.ogrenci_listele();
        }



        ///////////// Kitap İşlemlerimiz /////////////
        
        // Kitap eklenirken bookCheck metotu ile kontrol sağlayacaz ve eğer bu kitaptan zaten varsa ekleme yapmayacak ve true değerini dondurecek.
        // eğer kitaptan yoksa kitap ekleme işlemini yapacak ve geriye false değerini dondurecek.
        public Boolean kitap_ekle(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            if (bookCheck.checkBook(baseDAO, kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi))
            {
                return true;
            }
            else
            {
                baseDAO.kitap_ekle(kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi, kitap_adeti);
                return false;
            }

        }
        // butun kitaplar listelenecek.
        public DataSet kitap_listele()
        {
            return baseDAO.kitap_listele();
        }
        // verdiğimiz parametrelere gore ogrenci guncelleneecek.
        public void kitap_guncelle(int kitap_id, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            
            baseDAO.kitap_guncelle(kitap_id, kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi, kitap_adeti);
               
            
        }
        // kitap_id veya kitap_ismi ile arama işlemini sağlayacaz.
        public DataSet kitap_ara(String id_veya_ismi)
        {
            return baseDAO.kitap_ara(id_veya_ismi);
        }
        // borrowedChcek yardımıyla eğer bu kitap daha onceden odunc alındıysa yani odunc tablosunda var ise kitabı silme ve true değerini dondur
        // eğer kitap odunc tablosunda yoksa kitabı sil ve false değerini dondur
        public Boolean kitap_sil(int kitap_id)
        {
            if (borrowedCheck.borrowedCheck(baseDAO, kitap_id, 1))
            {
                return true;
            }
            else
            {
                baseDAO.kitap_sil(kitap_id);
                return false;
            }
        }
        public Boolean kitap_sayisi_kontrolEt(int kitap_id)
        {
            return baseDAO.kitap_sayisi_kontrolEt(kitap_id);
        }



        ///////////// Odunc İşlemlerimiz /////////////
        // ogrenci odunc bir kitap alacagi zaman eğer hali hazırda teslim etmemiş bir kitabı bulunuyorsa odunc kitap alamayacak ve geriye false donecek.
        // eğer teslim etmemiş kitabı kulunmuyorsa ogrenci kitabı teslim alacak ve geriye true değeri donecek.
        public Boolean odunc_ekle(int ogrenci_id, int kitap_id, String odunc_alma_tarihi)
        {
            if (baseDAO.odunc_teslim_edildiMi(ogrenci_id))
            {
                baseDAO.odunc_ekle(ogrenci_id, kitap_id, odunc_alma_tarihi);
                baseDAO.odunc_kitap_adet_azalt(kitap_id);
                return true;
            }
            else
            {
                return false;
            }
        }
        // butun odunc tablosu listelenecek.
        public DataSet odunc_listele()
        {
            return baseDAO.odunc_listele();
        }
        // Ödünç tablosundan isetdiğimiz öğrenciye ait ödünç alma bilgilerini yazdıracak.
        public DataSet odunc_ogrenci_listele(int ogrenci_id)
        {
            return baseDAO.odunc_ogrenci_listele(ogrenci_id);
        }
        // istediğimiz kitaba ait ödünç alma bilgilerini yazdıracak.
        public DataSet odunc_kitap_listele(int kitap_id)
        {
            return baseDAO.odunc_kitap_listele(kitap_id);
        }
        // odunc iade işlemlerinde,
        // ilk olarak odunc_id ve odunc_teslim_tarihi ile Odunc Tablosundaki teslim edilme tarihi guncelleyecegiz.
        // daha sonra kitap_id ile teslim edilen kitabın stok sayısını 1 arttıracağız.
        // daha sonra odunc_id ile Odunc Tablosundaki ogrencinin o işlemi için borcunu sıfırlayacağız.
        // daha sonra ogrenci_id ile Ogrenci Tablosundaki ogrencinin borcunu sıfırlayacağız.
        public void odunc_iade(int odunc_id, int ogrenci_id, int kitap_id, String odunc_teslim_tarihi)
        {
            baseDAO.odunc_teslim_tarihi_guncelle(odunc_id, odunc_teslim_tarihi);
            baseDAO.odunc_kitap_adet_arttir(kitap_id);
            baseDAO.odunc_ogrenci_borc_guncelle(odunc_id, 0);
            baseDAO.ogrenci_borc_guncelle(ogrenci_id, 0);
        }
        // teslim edilmeyen kitap için teslim süresi kontrolu yapılacak
        public int odunc_teslim_zaman_kontrol(int odunc_id)
        {
            return baseDAO.odunc_teslim_zaman_kontrol(odunc_id);
        }
        // öğreninin kitabı teslim edip etmediği bilgisi
        public Boolean odunc_teslim_edildiMi(int ogrenci_id)
        {
            if (baseDAO.odunc_teslim_edildiMi(ogrenci_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // kitabı teslim etmeyen öğrenci var mı yok mu genel kotnrol.
        public Boolean odunc_kitap_teslim_edildiMi(int kitap_id)
        {
            if (baseDAO.odunc_kitap_teslim_edildiMi(kitap_id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // bu odunc_id ile teslim edilmiş mi edilmemiş mi bilgisi
        public Boolean odunc_id_teslim_edildiMi(int odunc_id)
        {
            if (baseDAO.odunc_id_teslim_edildiMi(odunc_id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // odunc listesinden ogrenciyi siliyoruz
        public void odunc_ogrenci_sil(int ogrenci_id)
        {
            baseDAO.odunc_ogrenci_sil(ogrenci_id);
        }
        // odunc tablosundan kitabı siliyoruz
        public void odunc_kitap_sil(int kitap_id)
        {
            baseDAO.odunc_kitap_sil(kitap_id);
        }
        // odunc tablosundaki öğrencinin borcunu güncelliyoruz
        public void odunc_ogrenci_borc_guncelle(int odunc_id, int odunc_ogrenci_borc)
        {
            baseDAO.odunc_ogrenci_borc_guncelle(odunc_id, odunc_ogrenci_borc);
        }
        // öğrenci tablosundaki öğrencinin borcunu güncelliyoruz
        public void ogrenci_borc_guncelle(int ogrenci_id, int ogrenci_borc)
        {
            baseDAO.ogrenci_borc_guncelle(ogrenci_id, ogrenci_borc);
        }
        // odunc tablosunda arama yapılıyor
        public DataSet odunc_ara(String id_ad_isim)
        {
            return baseDAO.odunc_ara(id_ad_isim);
        }

        ///////////// Sayma ve Zedgraph İşlemleri İçin Methotlar /////////////

        // Kütüphanedeki butun kitapların sayısı
        public int kitap_sayisi_ogren()
        {
            return baseDAO.kitap_sayisi();
        }
        public int ogrenci_sayisi_ogren()
        {
            return baseDAO.ogrenci_sayisi();
        }
        // odunc tablosundaki kitapların sayısı
        public int odunc_alinan_kitap_sayisi()
        {
            return baseDAO.odunc_alinan_kitap_sayisi();
        }
        // odunc tablosunda teslim edilmeyen kitapların sayısı
        public int odunc_teslim_edilmeyen_kitap_sayisi()
        {
            return baseDAO.odunc_teslim_edilmeyen_kitap_sayisi();
        }
        // odunc tablosunda teslim edilen kitapların sayısı
        public int odunc_teslim_edilen_kitap_sayisi()
        {
            return odunc_alinan_kitap_sayisi() - odunc_teslim_edilmeyen_kitap_sayisi();
        }
        // öğrencinin kaç tane kitabı ödünç aldığı sayısını döndürecek.
        public int odunc_ogrenci_kitap_sayisi(int ogrenci_id)
        {
            return baseDAO.odunc_ogrenci_kitap_sayisi(ogrenci_id);
        }
        // bu kitabı kaç tane öğrencei aldığının sayısını döndürecek.
        public int odunc_kitap_ogrenci_sayisi(int kitap_id)
        {
            return baseDAO.odunc_kitap_ogrenci_sayisi(kitap_id);
        }
    }
}
