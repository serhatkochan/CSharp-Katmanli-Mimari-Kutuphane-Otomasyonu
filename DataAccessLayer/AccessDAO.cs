using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccessDAO : BaseDAO // BaeDAO ile AccessDAO'ya erişmek için kalıtım aldık.
    {
        // AccessDAO, OracleDAO, MsSQL, MySQL gibi sınıflar oluşturarak bu sınıfları BaseDAO dan katılım aldırtabiliriz
        // Böylelikle sadece baseDAO.ogrenci_ekle() gibi oluşturduğumuz methotu çağırırsak veritabanlarına bağımlı kalmayız.



        // Kullanacağımız Access C# komutları 
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter adapter;
        OleDbDataReader dataReader;


        ///////////// Veritabanı bağlantısı için constructor yardımıyla bağlantı stringimizi alıyoruz. /////////////

        // constructor olarak üst sınıfın constructoruna erişerek BaseDAO nun connectionStringini atadık.
        public AccessDAO(String connectionString) : base(connectionString)
        {
            baglanti = new OleDbConnection(connectionString);
        }


        ///////////// Ogrenci /////////////
        
        // Başlangıç olarak öğrenci borcuna 0 ekledik.
        public override void ogrenci_ekle(String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet) // override edilmiş ekle metodumuz. 
        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Ogrenci (ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet, ogrenci_borc) " +
                                                "values (@ogrenci_adi, @ogrenci_soyadi, @ogrenci_bolumu, @ogrenci_tcNo, @ogrenci_okulNo, @ogrenci_cinsiyet, 0)", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_adi", ogrenci_adi);
            komut.Parameters.AddWithValue("@ogrenci_soyadi", ogrenci_soyadi);
            komut.Parameters.AddWithValue("@ogrenci_bolumu", ogrenci_bolumu);
            komut.Parameters.AddWithValue("@ogrenci_tcNo", ogrenci_tcNo);
            komut.Parameters.AddWithValue("@ogrenci_okulNo", ogrenci_okulNo);
            komut.Parameters.AddWithValue("@ogrenci_cinsiyet", ogrenci_cinsiyet);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // öğrenciyi silecek
        public override void ogrenci_sil(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Ogrenci where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        // öğrenciyi guncelleyecek
        public override void ogrenci_guncelle(int ogrenci_id, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Ogrenci set ogrenci_adi = '" + ogrenci_adi + "', ogrenci_soyadi = '" + ogrenci_soyadi + "', ogrenci_bolumu = '" + ogrenci_bolumu + "', ogrenci_tcNo = '" + ogrenci_tcNo + "', ogrenci_okulNo = '" + ogrenci_okulNo + "', ogrenci_cinsiyet = '" + ogrenci_cinsiyet + "'  where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // öğrenciyi listelemek için dataset döndürecek
        public override DataSet ogrenci_listele()
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Ogrenci", baglanti);
            adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet.Tables[0]; // 0. indisten itibaren bana verileri doldur 
            baglanti.Close();
            return dataSet;
        } 
        // öğrenci aramak için dataset döndürecek
        public override DataSet ogrenci_ara(String adi_veya_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Ogrenci where ogrenci_adi like '%" + adi_veya_id + "%' or ogrenci_id like '%" + adi_veya_id + "%' ", baglanti);
            adapter = new OleDbDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            baglanti.Close();
            // form ekranında dataGridView1.DataSource = dataSet.Tables[0]; yazacaz.
            return dataSet;
        }
        // tcnoya ait ogrenci varsa true yoksa false değerini döndürecek.
        public override Boolean ogrenci_varMi_tcNo(string ogrenci_tcNo)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select ogrenci_tcNo from Ogrenci where ogrenci_tcNo = '" + ogrenci_tcNo + "'", baglanti);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        // tcnoya ait ogrenci varsa true yoska falsedeğerini dondurecek.
        public override Boolean ogrenci_varMi_okulNo(string ogrenci_okulNo)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select ogrenci_okulNo from Ogrenci where ogrenci_okulNo = '" + ogrenci_okulNo + "'", baglanti);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }


        }



        ///////////// Kitaplar /////////////

        // kitap eklenecek.
        public override void kitap_ekle(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Kitaplar (kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi, kitap_adeti) " +
                                                "values (@kitap_ismi, @kitap_turu, @kitap_yazari, @kitap_yayinevi, @kitap_sayfasi, @kitap_adeti)", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_adi", kitap_ismi);
            komut.Parameters.AddWithValue("@ogrenci_soyadi", kitap_turu);
            komut.Parameters.AddWithValue("@ogrenci_bolumu", kitap_yazari);
            komut.Parameters.AddWithValue("@ogrenci_tcNo", kitap_yayinevi);
            komut.Parameters.AddWithValue("@ogrenci_okulNo", kitap_sayfasi);
            komut.Parameters.AddWithValue("@ogrenci_cinsiyet", kitap_adeti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // kitap listelemek için dataset döndürecek
        public override DataSet kitap_listele()
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Kitaplar", baglanti);
            adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet.Tables[0]; // 0. indisten itibaren bana verileri doldur
            baglanti.Close();
            return dataSet;
        }
        // kitap guncelleyecek
        public override void kitap_guncelle(int kitap_id, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Kitaplar set kitap_ismi = '" + kitap_ismi + "', kitap_turu = '" + kitap_turu + "', kitap_yazari = '" + kitap_yazari + "', kitap_yayinevi = '" + kitap_yayinevi + "', kitap_sayfasi = '" + kitap_sayfasi + "', kitap_adeti = '" + kitap_adeti + "'  where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // kitap aramak için dataset döndürecek
        public override DataSet kitap_ara(String id_veya_ismi)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Kitaplar where kitap_id like '%" + id_veya_ismi + "%' or kitap_ismi like '%" + id_veya_ismi + "%'", baglanti);
            adapter = new OleDbDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            baglanti.Close();
            // form ekranında dataGridView1.DataSource = dataSet.Tables[0]; yazacaz.
            return dataSet;
        }
        // girdiğimiz bütün paramerlere ait kitap zaten var ise true yok ise false değerini döndürecek bize.
        public override Boolean kitap_varMi(string kitap_ismi, string kitap_turu, string kitap_yazari, string kitap_yayinevi, int kitap_sayfasi)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Kitaplar where kitap_ismi = @kitap_ismi and kitap_turu = @kitap_turu and kitap_yazari = @kitap_yazari and kitap_yayinevi = @kitap_yayinevi and kitap_sayfasi = @kitap_sayfasi", baglanti);
            komut.Parameters.AddWithValue("kitap_ismi", kitap_ismi);
            komut.Parameters.AddWithValue("kitap_turu", kitap_turu);
            komut.Parameters.AddWithValue("kitap_yazari", kitap_yazari);
            komut.Parameters.AddWithValue("kitap_yayinevi", kitap_yayinevi);
            komut.Parameters.AddWithValue("kitap_sayfasi", kitap_sayfasi);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        // kitabı silecek
        public override void kitap_sil(int kitap_id) 
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Kitaplar where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // eğer kitap stoğuynda kitap varsa true yoksa false değerinid öndürecek
        public override Boolean kitap_sayisi_kontrolEt(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Kitaplar where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("odunc_id", kitap_id);
            dataReader = komut.ExecuteReader();

            int kitap_sayisi = 0;

            while (dataReader.Read()) // odunc_alma_tairhi bilgisini oluşturduğumuz DateTime nesnesine aktarıyoruz.
            {
                kitap_sayisi = int.Parse(dataReader["kitap_adeti"].ToString());
            }

            baglanti.Close();

            if (kitap_sayisi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        ///////////// kitap ve ogrenci silme işlemleri için tabloda bu idlere sahip ogrenci veya kitap var mı ? sorguları. /////////////

        // Varsa true yoksa false döndürecek.
        public override Boolean odunc_kitap_varMi(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        // ödünç tablosunda öğrenci var mı kontrolü
        public override Boolean odunc_ogrenci_varMi(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }



        ///////////// Odunc /////////////
        
        // Odunc alma işlemi yapıldığı gibi, Teslim tarihinde Teslim edilmedi yazacak ve Borç başlangıç olarak 0 olarak atanacak.
        public override void odunc_ekle(int ogrenci_id, int kitap_id, String odunc_alma_tarihi)
        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Odunc (ogrenci_id, kitap_id, odunc_alma_tarihi, odunc_teslim_tarihi, odunc_ogrenci_borc) " +
                                                "values (@ogrenci_id, @kitap_id, @odunc_alma_tarihi, @odunc_teslim_tarihi, @odunc_ogrenci_borc)", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id);
            komut.Parameters.AddWithValue("@odunc_alma_tarihi", odunc_alma_tarihi);
            komut.Parameters.AddWithValue("@odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("@odunc_teslim_tarihi", 0);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // ödünç tablosunu listelemek için dataset döndürecek.
        public override DataSet odunc_listele()
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("Select * from Odunc", baglanti);
            adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet.Tables[0]; // 0. indisten itibaren bana verileri doldur
            baglanti.Close();
            return dataSet;
        }
        // teslim tarihi güncellenecek.
        public override void odunc_teslim_tarihi_guncelle(int odunc_id, String odunc_teslim_tarihi)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Odunc set odunc_teslim_tarihi = @odunc_teslim_tarihi where odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", odunc_teslim_tarihi);
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        // ogrenci tablosunda ogrencinin borcu guncellenecek.
        public override void ogrenci_borc_guncelle(int ogrenci_id, int ogrenci_borc)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Ogrenci set ogrenci_borc = @ogrenci_borc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("ogrenci_borc", ogrenci_borc);
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // odunc tablosunda öğrencinin borcu guncellenecek.
        public override void odunc_ogrenci_borc_guncelle(int odunc_id, int odunc_ogrenci_borc)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Odunc set odunc_ogrenci_borc = @odunc_ogrenci_borc where odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_ogrenci_borc", odunc_ogrenci_borc);
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        // odunc iade edildiyse stok 1 artacak
        public override void odunc_kitap_adet_arttir(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Kitaplar set kitap_adeti = kitap_adeti+1 where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // odunc alındıysa stok 1 azalacak
        public override void odunc_kitap_adet_azalt(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Kitaplar set kitap_adeti = kitap_adeti-1 where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // odunc tablosundaki bu kitaba ait ödünç verme bilgileri listenecek.
        public override DataSet odunc_kitap_listele(int kitap_id)
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Odunc where kitap_id =" + kitap_id + " ", baglanti);
            adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet.Tables[0]; // 0. indisten itibaren bana verileri doldur
            baglanti.Close();
            return dataSet;
        }
        // ödünç tablosunda bu öğrenciye ait ödünç alma bilgileri listenecek
        public override DataSet odunc_ogrenci_listele(int ogrenci_id)
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Odunc where ogrenci_id =" + ogrenci_id + " ", baglanti);
            adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet.Tables[0]; // 0. indisten itibaren bana verileri doldur
            baglanti.Close();
            return dataSet;
        }
        // eğer öğrenci kitabı teslim etmediyse false teslim edildiyse true değeri dönecek.
        public override Boolean odunc_teslim_edildiMi(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi and ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return false;
            }
            else
            {
                baglanti.Close();
                return true;
            }
        }
        // bu kitabı teslim etmeyen öürenci varsa false değerini döndürecek.
        // kitabı herkes teslim ettiyse true değerini döndürecek.
        public override Boolean odunc_kitap_teslim_edildiMi(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi and kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return false;
            }
            else
            {
                baglanti.Close();
                return true;
            }
        }
        // bu odunc id teslim edilmiş mi edilmemiş mi bilgisi. Teslim edilmediyse false değerini döndürecek.
        // teslim edildiyse true değerini döndürecek.
        public override Boolean odunc_id_teslim_edildiMi(int odunc_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi and odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return false;
            }
            else
            {
                baglanti.Close();
                return true;
            }
        }
        // teslim tarihinin geçip geçmediği kontrolü sağlanacak.
        public override int odunc_teslim_zaman_kontrol(int odunc_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            dataReader = komut.ExecuteReader();

            DateTime odunc_alma_tarihi = new DateTime();
            DateTime odunc_teslim_tarihi = new DateTime(); // bugünün zamanı ile teslim alınan zamanı karşılaştıracağımız DateTime

            odunc_teslim_tarihi = DateTime.Parse(DateTime.Now.ToString("d")); // bugünün zamanını atıyoruz

            while (dataReader.Read()) // odunc_alma_tairhi bilgisini oluşturduğumuz DateTime nesnesine aktarıyoruz.
            {
                odunc_alma_tarihi = DateTime.Parse(dataReader["odunc_alma_tarihi"].ToString());
            }
            TimeSpan span = odunc_teslim_tarihi.Subtract(odunc_alma_tarihi); // iki tarih arasındaki farkı alıyoruz.

            baglanti.Close();

            return int.Parse(span.TotalDays.ToString()); // kitabı aldıktan sonra kaç gün geçtiğinin bilgisi
        }
        // odunc tablosundan öğrenciyi siliyoruz
        public override void odunc_ogrenci_sil(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Odunc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // odunc tablosundan kitabı siliyoruz
        public override void odunc_kitap_sil(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Odunc where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // odunc tablosunda arama işlemi yapıyoruz
        public override DataSet odunc_ara(String id_ad_isim)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_id like '%" + id_ad_isim + "%' or ogrenci_id like '%" + id_ad_isim + "%' or kitap_id like '%" + id_ad_isim + "%'", baglanti);
            adapter = new OleDbDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            baglanti.Close();
            // form ekranında dataGridView1.DataSource = dataSet.Tables[0]; yazacaz.
            return dataSet;
        }




        ///////////// Sayma ve Zedgraph İşlemleri İçin Methotlar /////////////

        // kütüphanedeki toplam kitap sayısı
        public override int kitap_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Kitaplar", baglanti);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString()); // kolon ismi eklemedik hata olabilir ?
            }

            baglanti.Close();

            return sayi;
        }
        // kütüphanedeki toplam öğrenci sayısı
        public override int ogrenci_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Ogrenci", baglanti);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString()); // kolon ismi eklemedik hata olabilir ?
            }

            baglanti.Close();

            return sayi;
        }
        // kütüphanede bugüne kadar toplam alınan ödünç sayısı
        public override int odunc_alinan_kitap_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc", baglanti);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }
            baglanti.Close();

            return sayi;
        }
        // kütüphanede şuan teslim edilmeyen kitap sayısı
        public override int odunc_teslim_edilmeyen_kitap_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }

            baglanti.Close();

            return sayi;
        }
        // bu öğrencinin ktaç tane kitabı ödünç aldığı bilgisi
        public override int odunc_ogrenci_kitap_sayisi(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }

            baglanti.Close();

            return sayi;
        }
        // bu kitabı kaç tane öğrencinin ödünç aldığı bilgisi
        public override int odunc_kitap_ogrenci_sayisi(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }

            baglanti.Close();

            return sayi;
        }
        // odunc_edilen_kitap_sayisi = odunc_alinan_kitap_sayisi() - odunc_teslim_edilmeyen_kitap_sayisi()


    }
}