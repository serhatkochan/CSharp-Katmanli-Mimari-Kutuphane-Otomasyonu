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
    public partial class FBookOne : Form
    {
        public FBookOne()
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

        //form alta inecek
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

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void FBookOne_Load(object sender, EventArgs e)
        {
            dataGrid_book.EnableHeadersVisualStyles = false; // header color değişimi için bunu false yapıyoruz.
            dataGrid_book.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGrid_book.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGrid_book.DataSource = businessManager.kitap_ara(label_id.Text).Tables[0];
            dataGrid_book.Columns[0].HeaderText = "Kitap ID";
            dataGrid_book.Columns[1].HeaderText = "Kitap İsmi";
            dataGrid_book.Columns[2].HeaderText = "Kitap Türü";
            dataGrid_book.Columns[3].HeaderText = "Kitap Yazarı";
            dataGrid_book.Columns[4].HeaderText = "Kitap Yayınevi";
            dataGrid_book.Columns[5].HeaderText = "Kitap Sayfası";
            dataGrid_book.Columns[6].HeaderText = "Kitap Adeti";
            dataGrid_book.ClearSelection();
        }
    }
}
