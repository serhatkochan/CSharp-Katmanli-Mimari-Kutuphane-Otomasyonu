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
    public partial class FStudentEkle : Form

    {
        public FStudentEkle()
        {
            InitializeComponent();
        }

        // formun yerini değiştirmek için kullanacağımız dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());


        // formu kapat
        private void icon_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // formu alta indir
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // formun yerini değiştir
        private void panelMenuHorizontal_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        // txt ler boşsa ekleme işlemi yapmayacak.
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (textler_bosMu())
            {
                MessageBox.Show("Boşta alan kalmasın. Ekleme işlemi başarısız.");
            }
            else
            {
                if(txt_tcNo.Text.Length != 11){ // tc numarası, okul numarsı ve cinsiyet doğru girilmediyse uyarı mesajı
                    MessageBox.Show("Tc Numarası 11 haneli olmalı. Ekleme işlemi başarısız.");
                }
                else if(txt_okulNo.Text.Length != 9)
                {
                    MessageBox.Show("Okul Numarası 9 haneli olmalı. Ekleme işlemi başarısız.");
                }
                else if (!txt_cinsiyet.Text.Equals("Kadın") && !txt_cinsiyet.Text.Equals("Erkek"))
                {
                    MessageBox.Show("Doğru cinsiyet giriniz(Kadın / Erkek). Ekleme işlemi başarısız.");
                }
                else
                { // doğru girildiyse ekleme işlemlerini sorgula
                    if (businessManager.ogrenci_ekle(txt_adi.Text, txt_soyadi.Text, txt_bolumu.Text, txt_tcNo.Text, txt_okulNo.Text, txt_cinsiyet.Text))
                    {
                        MessageBox.Show("Bu bilgilere ait öğrenci zaten var. Ekleme işlemi başarısız.");
                    }
                    else
                    {
                        //businessManager.ogrenci_ekle(txt_adi.Text, txt_soyadi.Text, txt_bolumu.Text, txt_tcNo.Text, txt_okulNo.Text, txt_cinsiyet.Text);
                        MessageBox.Show("Ekleme işlemi başarılı.");
                        this.Close();
                    }
                }
            }
        }
    }
}