using BusinessLogicServiceLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FBook : Form
    {
        public FBook()
        {
            InitializeComponent();
        }

        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());
        
        // kitaplar listelenecek
        public void kitap_listele()
        {
            if (businessManager.kitap_sayisi_ogren() == 0) // eğer kitaplar tablosunda kitap yoksa 
            {
                dataGrid_book.DataSource = "";
            }
            else
            {
                dataGrid_book.DataSource = businessManager.kitap_listele().Tables[0];
                dataGrid_book.Columns[0].HeaderText = "Kitap ID";
                dataGrid_book.Columns[1].HeaderText = "Kitap İsmi";
                dataGrid_book.Columns[2].HeaderText = "Kitap Türü";
                dataGrid_book.Columns[3].HeaderText = "Kitap Yazarı";
                dataGrid_book.Columns[4].HeaderText = "Kitap Yayınevi";
                dataGrid_book.Columns[5].HeaderText = "Kitap Sayfası";
                dataGrid_book.Columns[6].HeaderText = "Kitap Adeti";
                // kitapları listele ve colon başlıklarını değiştir
            }
        }
        
        // program yüklenirken colon başlıklarının rengini değiştir ve kitapları listele
        private void FBook_Load(object sender, EventArgs e)
        {
            dataGrid_book.EnableHeadersVisualStyles = false;
            dataGrid_book.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGrid_book.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            kitap_listele();
            txt_aranacakKitap.Text = "ID veya İsmi";
        }


        // kitaplar listenecek.
        private void btn_kitapListele_Click(object sender, EventArgs e)
        {
            kitap_listele();
        }

        // kitap ekleme işlemi için yeni bir form açılacak işlem bittikten sonra kitaplar tekrar listenecek.
        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            FBookEkle fBookEkle = new FBookEkle();
            fBookEkle.ShowDialog();
            dataGrid_book.DataSource = businessManager.kitap_listele().Tables[0];
        }

        // güncelleme işlemi için yeni bi form açılacak işlem bititkten sonra kitaplar tekrar listenecek.
        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            FBookGuncelle fBookGuncelle = new FBookGuncelle();
            if (dataGrid_book.SelectedRows.Count > 0)
            { // book.check kontorl et ve kitaptan zaten varsa güncelleme !!!!!!!!!!!!!!!!!
                fBookGuncelle.label_id.Text = dataGrid_book.CurrentRow.Cells[0].Value.ToString();
                fBookGuncelle.txt_ismi.Text = dataGrid_book.CurrentRow.Cells[1].Value.ToString();
                fBookGuncelle.txt_turu.Text = dataGrid_book.CurrentRow.Cells[2].Value.ToString();
                fBookGuncelle.txt_yazari.Text = dataGrid_book.CurrentRow.Cells[3].Value.ToString();
                fBookGuncelle.txt_yayinevi.Text = dataGrid_book.CurrentRow.Cells[4].Value.ToString();
                fBookGuncelle.txt_sayfasi.Text = dataGrid_book.CurrentRow.Cells[5].Value.ToString();
                fBookGuncelle.txt_adeti.Text = dataGrid_book.CurrentRow.Cells[6].Value.ToString();
                fBookGuncelle.ShowDialog();
                // güncelleme bilgileri forma aktarılacak.
                dataGrid_book.DataSource = businessManager.kitap_listele().Tables[0];

            }
            else
            {
                MessageBox.Show("Güncellemek istediğiniz kitabı seçiniz.");
            }
        }

        // ilgili kitabın teslim edilip edilmeme durumu kontrol edilecek.
        // teslim edilmediyse emin misiniz penceresi açılacak.
        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            if (dataGrid_book.SelectedRows.Count > 0)
            {
                // id'yi birden çok kullanacağımız için bi değişkene atadık.
                int id = int.Parse(dataGrid_book.CurrentRow.Cells[0].Value.ToString());

                // eğer kitabı teslim etmeyen öğrenci varsa uyarı mesajı gönderecek ve soracak.
                if (businessManager.odunc_kitap_teslim_edildiMi(id))
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Bu kitabı teslim etmeyen öğrenci bulunuyor. Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        businessManager.odunc_kitap_sil(id);
                        businessManager.kitap_sil(id); // her iki tablodan da kitap silindi.
                        MessageBox.Show("Kitap her iki tablodan da silindi.");

                        kitap_listele();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılmadı.");
                    }
                }
                else
                { // direkt kitap tablosundan silinecek.
                    businessManager.odunc_kitap_sil(id);
                    businessManager.kitap_sil(id);
                    MessageBox.Show("Kitap silindi.");
                    kitap_listele();
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz öğrenceiyi seçiniz.");
            }
        }

        // kitap için oluşturduğumuz ödünç formu açılacak.
        // kitap id yi bu forma aktarıyoruz.
        private void btn_oduncIslemleri_Click(object sender, EventArgs e)
        {
            FBookOdunc fBookOdunc = new FBookOdunc();
            if (dataGrid_book.SelectedRows.Count > 0)
            {
                // kitap  id yi aktardık
                fBookOdunc.label_id.Text = dataGrid_book.CurrentRow.Cells[0].Value.ToString();
                fBookOdunc.ShowDialog();
                dataGrid_book.DataSource = businessManager.kitap_listele().Tables[0];
                //dataGrid_student.DataSource = businessManager.odunc_ogrenci_listele(int.Parse(dataGrid_student.CurrentRow.Cells[0].Value.ToString())).Tables[0];
            }
            else
            {
                MessageBox.Show("Ödünç İşlemleri yapmak istediğiniz öğrenciyi seçiniz.");
            }
        }

        // txt boşsa uyarı mesajı gelecek
        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            if (txt_aranacakKitap.Text.Equals("ID veya İsmi"))
            {
                MessageBox.Show("Arama yapmak için ID veya Kitap İsmini giriniz.");
            }
            else
            {
                dataGrid_book.DataSource = businessManager.kitap_ara(txt_aranacakKitap.Text).Tables[0];
            }
        }


        // arnacak kitap için oluşturduğumuz text kısmında ID veya Ad ile arama yapması için ipucu bırakıyoruz.
        // bu kısma tıkladığında text silinecek, tekrar geri çektiğimizde tekrardan ipucumuz yazacak.
        // eğer içerisine bir şey yazdıysak silinmeyecek.
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

        // colonlara tıklandığında sıralama işlemi yapmayacak.
        private void dataGrid_book_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
