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
    public partial class FBookGuncelle : Form
    {
        public FBookGuncelle()
        {
            InitializeComponent();
        }

        // ekranın yerini değiştirmek için gerekli dll
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());


        // güncelleme işlemi için txtlerin içleri dolu olmalı.
        public Boolean textler_bosMu()
        {
            if(txt_ismi.Text.Equals("") || txt_turu.Text.Equals("") || txt_yazari.Text.Equals("") || txt_yayinevi.Text.Equals("") || txt_sayfasi.Text.Equals("") || txt_adeti.Text.Equals("")){
                return true;
            }
            return false;
        }

        // txt ler boş olmayacak
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (textler_bosMu())
            {
                MessageBox.Show("Boşta alan kalmasın. Güncelleme işlemi başarısız.");
            }
            else
            {
                businessManager.kitap_guncelle(int.Parse(label_id.Text), txt_ismi.Text, txt_turu.Text, txt_yazari.Text, txt_yayinevi.Text, int.Parse(txt_sayfasi.Text), int.Parse(txt_adeti.Text));
                
                MessageBox.Show("Güncelleme işlemi başarılı.");
                this.Close();
            }     
        }

        // ekranın yeri değişecek
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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
    }
}
