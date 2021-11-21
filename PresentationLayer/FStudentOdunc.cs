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
    public partial class FStudentOdunc : Form
    {
        public FStudentOdunc()
        {
            InitializeComponent();
        }

        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());


        // listeleme işlemini tekrar tekrar kullanacağımız için metot olarak yazdık. gerektiğinde kullanacaz.
        private void odunc_listesini_goster() 
        {
            if (businessManager.odunc_ogrenci_kitap_sayisi(int.Parse(label_id.Text)) == 0)
            {
                dataGrid_odunc.DataSource = "";
                label_bilgilendirme.Text = "Ödünç aldığınız kitap yok.";
                label_bilgilendirme.Visible = true; // ödünç alınan kitap yoksa, ekranda bilgilendirme mesajı olacak.
            }
            else
            {
                dataGrid_odunc.DataSource = businessManager.odunc_ogrenci_listele(int.Parse(label_id.Text)).Tables[0];
                dataGrid_odunc.Columns[0].HeaderText = "Ödünç ID";
                dataGrid_odunc.Columns[1].HeaderText = "Öğrenci ID";
                dataGrid_odunc.Columns[2].HeaderText = "Kitap ID";
                dataGrid_odunc.Columns[3].HeaderText = "Ödünç Alma Tarihi";
                dataGrid_odunc.Columns[4].HeaderText = "Teslim Etme Tarihi";
                dataGrid_odunc.Columns[5].HeaderText = "Öğrenci Borcu";
                // listele ve kolon isimlerini değiştir
                dataGrid_odunc.ClearSelection();

                label_bilgilendirme.Visible = false;
            }
        }

        // duruma göre satır renklerini düzenle
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

                    if (gecen_zaman > 15)
                    {
                        renk.BackColor = Color.FromArgb(250, 128, 114); // kırmızı tonu
                        renk.ForeColor = Color.FromArgb(192, 192, 192); // beyaz tonu

                        int ogrenci_borc = gecen_zaman - 15; // öğrenci borcunu güncelliyoruz.
                        businessManager.odunc_ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()), ogrenci_borc);
                        businessManager.ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["ogrenci_id"].Value.ToString()), ogrenci_borc);

                    }
                    else if (gecen_zaman >= 13)
                    {
                        renk.BackColor = Color.FromArgb(253, 253, 150); // sarı tonu
                        renk.ForeColor = Color.FromArgb(85, 93, 80); // ebony

                    }
                }
                dataGridView.Rows[i].DefaultCellStyle = renk;
            }
        }


        // form yüklenirken kolon rengi değişecek
        // ilgili bilgilendirme mesajları yazılacak
        // odunc listelenecek ve renkler değişecek
        private void FStudentOdunc_Load(object sender, EventArgs e)
        {
            dataGrid_odunc.EnableHeadersVisualStyles = false;
            dataGrid_odunc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGrid_odunc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            txt_aranacakKitap.Text = "ID veya İsmi";
            groupBox_arama.Visible = false;
            btn_oduncAl.Visible = false;

            odunc_listesini_goster(); // yazdığımız metotu burada kullanıyoruz. başlangıç olarak ödünç alınanlar listeleniyor.
            grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
            dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }

        // ekranın yerini değiştirmek için gerekli dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        // form kapatılacak
        private void icon_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // form alta inecek
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // ekranın yeri değişecek
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // öğrencini ödünç aldığı kitaplar gösterilecek
        private void btn_aldigimKitap_Click(object sender, EventArgs e)
        {
            groupBox_arama.Visible = false;
            btn_oduncAl.Visible = false;
            btn_kitaplar.Visible = true;
            odunc_listesini_goster();
            grid_renkleri_degistir(dataGrid_odunc); // tabloda duruma göre renkler gözükecek.
            dataGrid_odunc.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }

        // ilgili kitabı iade edecez
        private void btn_iadeEt_Click(object sender, EventArgs e)
        {
            if (dataGrid_odunc.SelectedRows.Count > 0)
            {
                DateTime dateTime = DateTime.Now;
                if (!businessManager.odunc_id_teslim_edildiMi(int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString())))
                { // zaten teslim edilmiş kitabı bidaha teslim edemeyiz ?
                    MessageBox.Show("Bu kitap zaten teslim edildi.");
                }
                else
                {
                    businessManager.odunc_iade(int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString()), int.Parse(label_id.Text), int.Parse(dataGrid_odunc.CurrentRow.Cells[2].Value.ToString()), dateTime.ToString("d"));
                    MessageBox.Show("İade işlemi başarılı.");
                    this.Close(); // iade işleminden sonra formu kapat
                }
            }
            else
            { // bir seçim yapılmadıysa..
                MessageBox.Show("İade işlemi yapmak istediğiniz kitabı seçiniz.");
            }
        }

        // kitapları listele 
        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            groupBox_arama.Visible = true; // kitap arama işlemi yapılabilecek.
            btn_kitaplar.Visible = false;
            btn_oduncAl.Visible = true;
            if (businessManager.kitap_sayisi_ogren() == 0) // eğer kitaplar tablosunda kitap yoksa 
            {
                dataGrid_odunc.DataSource = "";
                label_bilgilendirme.Text = "Kütüphanede kayıtlı kitap yok.";
                label_bilgilendirme.Visible = true; // ödünç alınan kitap yoksa, ekranda bilgilendirme mesajı olacak.
            }
            else
            { 
                dataGrid_odunc.DataSource = businessManager.kitap_listele().Tables[0];
                dataGrid_odunc.Columns[0].HeaderText = "Kitap ID";
                dataGrid_odunc.Columns[1].HeaderText = "Kitap İsmi";
                dataGrid_odunc.Columns[2].HeaderText = "Kitap Türü";
                dataGrid_odunc.Columns[3].HeaderText = "Kitap Yazarı";
                dataGrid_odunc.Columns[4].HeaderText = "Kitap Yayınevi";
                dataGrid_odunc.Columns[5].HeaderText = "Kitap Sayfası";
                dataGrid_odunc.Columns[6].HeaderText = "Kitap Adeti";
                // kitapları listele ve colon başlıklaırnı değiştir
                label_bilgilendirme.Visible = false;
            }
        }

        // ilgili kitap ödünç alınabilecek.
        private void btn_oduncAl_Click(object sender, EventArgs e)
        {
            if (dataGrid_odunc.SelectedRows.Count > 0) // seçili değilse
            {
                DateTime dateTime = DateTime.Now;
                
                if (businessManager.kitap_sayisi_kontrolEt(int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString())))
                { // kitap stoğu varsa kontol sağla
                    if (businessManager.odunc_ekle(int.Parse(label_id.Text), int.Parse(dataGrid_odunc.CurrentRow.Cells[0].Value.ToString()), dateTime.ToString("d")))
                    { // ödünç alma işlemi yapıldıysa işlem başarılı yaz ve programdan çık.
                        MessageBox.Show("Ödünç alma işlemi başarılı.");
                        this.Close();
                    }
                    else
                    { // ödünç alınmadıysa bilgilendirme mesajı
                        MessageBox.Show("Teslim etmediğiniz kitap bulunduğu için ödünç kitap alamazsınız.");
                    }
                }
                else
                { // kitap stoğu yoksa ödünç alma işlemi başarısız.
                    MessageBox.Show("Kütüphane stoğunda bu kitaptan yok.");
                }
            }
            else
            { // bir seçim yapılmadıysa..
                MessageBox.Show("Ödünç İşlemleri yapmak istediğiniz kitabı seçiniz.");
            }
        }

        // arama işleminde txt boşsa uyarı mesajı yolla
        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
                if (txt_aranacakKitap.Text.Equals("ID veya İsmi"))
            {
                MessageBox.Show("Arama yapmak için ID veya Kitap İsmini giriniz.");
            }
            else
            {
                dataGrid_odunc.DataSource = businessManager.kitap_ara(txt_aranacakKitap.Text).Tables[0];
            }
        }

        // txt ye tıklandığında içerisini boşalt, başka yere tıklandığında içerisini eski haline getir.
        private void txt_aranacakKitap_Enter(object sender, EventArgs e)
        {
            if (txt_aranacakKitap.Text.Equals("ID veya İsmi"))
            {
                txt_aranacakKitap.Text = "";
            }
        }

        private void txt_aranacakKitap_Leave(object sender, EventArgs e)
        {
            if (txt_aranacakKitap.Text.Equals(""))
            {
                txt_aranacakKitap.Text = "ID veya İsmi";
            }
        }

        // colonlara tıklandığında sıralama işlemi yapılmayacak.
        private void dataGrid_odunc_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // çift tıklandığında ilgili kitabın 
        private void dataGrid_odunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!btn_kitapAra.Visible)
            {
                FBookOne fBookOne = new FBookOne(); dataGrid_odunc.DataSource = businessManager.kitap_ara(dataGrid_odunc.CurrentRow.Cells[2].Value.ToString()).Tables[0];
                // book.check kontorl et ve kitaptan zaten varsa güncelleme !!!!!!!!!!!!!!!!!
                fBookOne.label_id.Text = dataGrid_odunc.CurrentRow.Cells[0].Value.ToString();
                fBookOne.ShowDialog();
                btn_aldigimKitap_Click(sender, e);
                // güncelleme bilgileri forma aktarılacak.
            } // kitaplar kısmında zaten kitap bilgileri var.

        }
    }
}
