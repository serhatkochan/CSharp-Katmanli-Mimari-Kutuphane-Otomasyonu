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
    public partial class FStudentOne : Form
    {
        public FStudentOne()
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

        private void FStudentOne_Load(object sender, EventArgs e)
        {
            dataGrid_book.EnableHeadersVisualStyles = false; // header color değişimi için bunu false yapıyoruz.
            dataGrid_book.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGrid_book.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid_book.DataSource = businessManager.ogrenci_ara(label_id.Text).Tables[0];

            dataGrid_book.Columns[0].HeaderText = "Öğrenci ID";
            dataGrid_book.Columns[1].HeaderText = "Öğrenci Adı";
            dataGrid_book.Columns[2].HeaderText = "Öğrenci Soyadı";
            dataGrid_book.Columns[3].HeaderText = "Öğrenci Bölümü";
            dataGrid_book.Columns[4].HeaderText = "Öğrenci Tc Numarası";
            dataGrid_book.Columns[5].HeaderText = "Öğrenci Okul Numarası";
            dataGrid_book.Columns[6].HeaderText = "Öğrenci Cinsiyeti";
            dataGrid_book.Columns[7].HeaderText = "Öğrenci Borcu";
            // kolon isimlerini değiştir
            dataGrid_book.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }
    }
}
