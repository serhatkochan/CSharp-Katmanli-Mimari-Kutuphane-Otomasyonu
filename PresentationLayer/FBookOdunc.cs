using BusinessLogicServiceLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FBookOdunc : Form
    {
        public FBookOdunc()
        {
            InitializeComponent();
        }

        // iş katmanında kullanacağımız metotlar
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());


        private void odunc_listesini_goster() // tekrar tekrar kullanacağımız için metot olarak yazdık. gerektiğinde kullanacaz.
        {
            if (businessManager.odunc_kitap_ogrenci_sayisi(int.Parse(label_id.Text)) == 0)
            {
                dataGrid_odunc.DataSource = "";
                label_bilgilendirme.Text = "Ödünç alan öğrenci yok.";
                label_bilgilendirme.Visible = true; // ödünç alan öğrenci yoksa, ekranda bilgilendirme mesajı olacak.
            }
            else
            {
                dataGrid_odunc.DataSource = businessManager.odunc_kitap_listele(int.Parse(label_id.Text)).Tables[0];
                dataGrid_odunc.Columns[0].HeaderText = "Ödünç ID";
                dataGrid_odunc.Columns[1].HeaderText = "Öğrenci ID";
                dataGrid_odunc.Columns[2].HeaderText = "Kitap ID";
                dataGrid_odunc.Columns[3].HeaderText = "Ödünç Alma Tarihi";
                dataGrid_odunc.Columns[4].HeaderText = "Teslim Etme Tarihi";
                dataGrid_odunc.Columns[5].HeaderText = "Öğrenci Borcu";
                // tablo isimleri değiştirildi ve listelendi
                dataGrid_odunc.ClearSelection();

                label_bilgilendirme.Visible = false;
            }
        }

        // duruma göre renk değiştirme işlemleri yapıldı
        private void grid_renkleri_degistir(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); // istediğiimiz renkleri atayacağımız nesne
                if (!(dataGridView.Rows[i].Cells["odunc_teslim_tarihi"].Value.ToString()).Equals("Teslim edilmedi"))
                {// eğer öğrenci kitabı teslim edildiyse
                    renk.BackColor = Color.FromArgb(69, 176, 140); // yeşil tonu arka plan
                    renk.ForeColor = Color.FromArgb(255, 255, 240); // beyaz tonu yazı rengi
                }
                else
                {
                    // 15 gün teslim süresi
                    // kalan zamanın bilgisini bize getirecek.
                    int gecen_zaman = businessManager.odunc_teslim_zaman_kontrol(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()));
                    
                    if(gecen_zaman > 15) // geçtiyse
                    {
                        renk.BackColor = Color.FromArgb(250, 128, 114); // kırmızı tonu
                        renk.ForeColor = Color.FromArgb(192, 192, 192); // beyaz tonu

                        int ogrenci_borc = gecen_zaman - 15; // öğrenci borcunu güncelliyoruz.
                        businessManager.odunc_ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()), ogrenci_borc);
                        businessManager.ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["ogrenci_id"].Value.ToString()), ogrenci_borc);
                    }
                    else if(gecen_zaman >= 13) // 2 gün kaldıysa
                    {
                        renk.BackColor = Color.FromArgb(253, 253, 150); // sarı tonu
                        renk.ForeColor = Color.FromArgb(85, 93, 80); // ebony

                    }
                }
                dataGridView.Rows[i].DefaultCellStyle = renk; // ilgili satırın rengini değiştir
            }
        }

        // form ilk açıldığında
        private void FBookOdunc_Load(object sender, EventArgs e)
        {
            // header rengi değiştirildi
            dataGrid_odunc.EnableHeadersVisualStyles = false;
            dataGrid_odunc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGrid_odunc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // başlangıç olarak gözükmesini istediğimiz buton ve txt bilgisi
            txt_aranacakOgrenci.Text = "ID veya Adı";
            groupBox_arama.Visible = false;
            btn_oduncVer.Visible = false;
            // kitabı ödünç alan öğrenciler ilgili renklere göre listeleniyor.
            odunc_listesini_goster(); // ödünç alanlar listeleniyor.
            grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
            dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }

        // ekranın yerini değiştirmek için gerekli dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // çarpıya tıklandığında form kapatılacak.
        private void icon_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ekran küçülecek
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // ekranda formun yerideğişecek
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ödünç alan öğrenciler listelenecek.
        private void btn_alanOgrenciler_Click(object sender, EventArgs e)
        {
            groupBox_arama.Visible = false;
            btn_oduncVer.Visible = false;
            btn_iadeAl.Visible = true;
            odunc_listesini_goster();
            grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
            dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }

        // ilgili kitabı ilgili öğrenci alabilecek.
        private void btn_iadeAl_Click(object sender, EventArgs e)
        {
            if (dataGrid_odunc.SelectedRows.Count > 0) // eğer kitap varsa
            {
                DateTime dateTime = DateTime.Now;
                if (!businessManager.odunc_id_teslim_edildiMi(int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Bu kitap zaten iade alındı."); // iade alınan kitap tekrardan iade alınamıyor ?
                }
                else
                {
                    businessManager.odunc_iade(int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString()), int.Parse(dataGrid_odunc.CurrentRow.Cells[1].Value.ToString()), int.Parse(label_id.Text), dateTime.ToString("d"));
                    MessageBox.Show("İade işlemi başarılı.");
                    this.Close(); // iade işlemini yap ve formu kapat.
                }
            }
            else
            { // bir seçim yapılmadıysa..
                MessageBox.Show("İade işlemi yapmak istediğiniz öğrenciyi seçiniz.");
            }
        }

        // öğrenciler listelenecek.
        private void btn_ogrenciler_Click(object sender, EventArgs e)
        {
            groupBox_arama.Visible = true; // öğrenci arama işlemi yapılabilecek.
            btn_iadeAl.Visible = false; // öğrenci iade alamayacak
            btn_oduncVer.Visible = true; // öğrenciye bu kitabı ödünç verebilecek.

            if (businessManager.ogrenci_sayisi_ogren() == 0) // eğer öğrenciler tablosunda öğrenci yoksa 
            {
                dataGrid_odunc.DataSource = "";
                label_bilgilendirme.Text = "Kütüphanede kayıtlı öğrenci yok.";
                label_bilgilendirme.Visible = true; // ödünç alan öğrenci yoksa, ekranda bilgilendirme mesajı olacak.
            }
            else
            {
                dataGrid_odunc.DataSource = businessManager.ogrenci_listele().Tables[0];
                dataGrid_odunc.Columns[0].HeaderText = "Öğrenci ID";
                dataGrid_odunc.Columns[1].HeaderText = "Öğrenci Adı";
                dataGrid_odunc.Columns[2].HeaderText = "Öğrenci Soyadı";
                dataGrid_odunc.Columns[3].HeaderText = "Öğrenci Bölümü";
                dataGrid_odunc.Columns[4].HeaderText = "Öğrenci Tc Numarası";
                dataGrid_odunc.Columns[5].HeaderText = "Öğrenci Okul Numarası";
                dataGrid_odunc.Columns[6].HeaderText = "Öğrenci Cinsiyeti";
                dataGrid_odunc.Columns[7].HeaderText = "Öğrenci Borcu";
                label_bilgilendirme.Visible = false;
                // öürencileri listele ve header başlıklarını değiştir
            }
        }

        // öğrenciye ilgili kitabı ödünç verebilecez.
        private void btn_oduncVer_Click(object sender, EventArgs e)
        {
            if (dataGrid_odunc.SelectedRows.Count > 0) // öğrenci seçildiyse
            {
                DateTime dateTime = DateTime.Now;
                if (businessManager.kitap_sayisi_kontrolEt(int.Parse(label_id.Text))) // kitabın stoğu müsaitse.
                {
                    if (businessManager.odunc_ekle(int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString()), int.Parse(label_id.Text), dateTime.ToString("d")))
                    { // ödünç alma işlemi yapıldıysa işlem başarılı yaz ve programdan çık.
                        MessageBox.Show("Ödünç verme işlemi başarılı.");
                        this.Close();
                    }
                    else
                    { // ödünç alınmadıysa bilgilendirme mesajı
                        MessageBox.Show("Öğrencinin teslim etmediği kitap bulunduğu için ödünç veremezsiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Kütüphane stoğunda bu kitaptan yok.");
                }

            }
            else
            { // bir seçim yapılmadıysa..
                MessageBox.Show("Ödünç İşlemleri yapmak istediğiniz öğrenciyi seçiniz.");
            }
        }

        // öğrenci arama işlemi
        private void btn_ogrenciAra_Click(object sender, EventArgs e)
        {
            if (txt_aranacakOgrenci.Text.Equals("ID veya Adı")) // bir şey yazılmadıysa
            {
                MessageBox.Show("Arama yapmak için ID veya Öğrenci Adını giriniz.");
            }
            else
            {
                dataGrid_odunc.DataSource = businessManager.kitap_ara(txt_aranacakOgrenci.Text).Tables[0];
            }
        }

        // txtnin içine tıklandığında içerisini boşalt
        private void txt_aranacakOgrenci_Enter(object sender, EventArgs e)
        {
            if (txt_aranacakOgrenci.Text.Equals("ID veya Adı"))
            {
                txt_aranacakOgrenci.Text = "";
            }
        }

        // txt dışında bir yere tıklandığında txt içerisini tekrar eski haline getir
        private void txt_aranacakOgrenci_Leave(object sender, EventArgs e)
        {
            if (txt_aranacakOgrenci.Text.Equals(""))
            {
                txt_aranacakOgrenci.Text = "ID veya Adı";
            }
        }

        // colon başlıklarına tıklanarak sıralama işlemi yapılmayacak.
        private void dataGrid_odunc_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // çift tıklandığında ilgini öğrencinin bilgilerini gösteren ayrı bir form
        private void dataGrid_odunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_ogrenciAra.Visible)
            {
                FStudentOne fStudentOne = new FStudentOne(); 
                dataGrid_odunc.DataSource = businessManager.ogrenci_ara(dataGrid_odunc.CurrentRow.Cells[1].Value.ToString()).Tables[0];
                // book.check kontorl et ve kitaptan zaten varsa güncelleme !!!!!!!!!!!!!!!!!
                fStudentOne.label_id.Text = dataGrid_odunc.CurrentRow.Cells[0].Value.ToString();
                fStudentOne.ShowDialog();
                btn_alanOgrenciler_Click(sender, e);
                // güncelleme bilgileri forma aktarılacak.
            } // kitaplar kısmında zaten kitap bilgileri var.
        }
    }
}
