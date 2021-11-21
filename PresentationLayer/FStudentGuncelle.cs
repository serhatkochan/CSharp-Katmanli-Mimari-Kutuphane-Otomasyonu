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
    public partial class FStudentGuncelle : Form
    {
        public FStudentGuncelle()
        {
            InitializeComponent();
        }

        // ekranın yerini değişltirmek için kullanacağımız dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());

        // textlerin boş olup olmadığını kontrol etme metodu
        public Boolean textler_bosMu() 
        {
            if (txt_adi.Text.Equals("") || txt_soyadi.Text.Equals("") || txt_bolumu.Text.Equals("") || txt_tcNo.Text.Equals("") || txt_okulNo.Text.Equals("") || txt_cinsiyet.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // txt ler boşsa güncelleme yapılmayacak
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (textler_bosMu())
            {
                MessageBox.Show("Boşta alan kalmasın. Güncelleme işlemi başarısız.");
            }
            else
            {
                if (txt_tcNo.Text.Length != 11) // tc numarası 11 haneli değilse
                {
                    MessageBox.Show("Tc Numarası 11 haneli olmalı. Ekleme işlemi başarısız.");
                }
                else if (txt_okulNo.Text.Length != 9) // okul numarası 9 haneli değilse
                {
                    MessageBox.Show("Okul Numarası 9 haneli olmalı. Ekleme işlemi başarısız.");
                }
                else if (!txt_cinsiyet.Text.Equals("Kadın") && !txt_cinsiyet.Text.Equals("Erkek"))
                { // cinsiyet seçimi yanlışsa
                    MessageBox.Show("Doğru cinsiyet giriniz(Kadın / Erkek). Ekleme işlemi başarısız.");
                }
                else
                { // bütün durumlar sağlanıyorsa öğrenci güncelleme işlemini sorgula.
                    if (businessManager.ogrenci_guncelle(int.Parse(label_id.Text), txt_adi.Text, txt_soyadi.Text, txt_bolumu.Text, txt_tcNo.Text, txt_okulNo.Text, txt_cinsiyet.Text))
                    {
                        MessageBox.Show("Bu bilgilere ait öğrenci zaten var. Güncelleme işlemi başarısız.");
                    }
                    else
                    { // tekardan businessManager.ogrenci_guncelle'yi kullanmaya gerek var mı kontrol etmeyi unutma !!!!!
                        businessManager.ogrenci_guncelle(int.Parse(label_id.Text), txt_adi.Text, txt_soyadi.Text, txt_bolumu.Text, txt_tcNo.Text, txt_okulNo.Text, txt_cinsiyet.Text);
                        MessageBox.Show("Güncelleme işlemi başarılı.");
                        this.Close();
                    }
                }
            }
        }

        // ekranın yerini değiştir
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // formdan çık
        private void icon_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // formu alta indir
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
