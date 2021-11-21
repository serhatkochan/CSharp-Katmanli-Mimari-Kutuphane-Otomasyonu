using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Programı ekranda gezdirmek için gerekli

namespace PresentationLayer
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        //  Program çalışırken ekranın konumunu değiştirmek için gerekli
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // program çalıştığı gibi FMainScreen formunu ekrana getiriyoruz
        private void FMain_Load(object sender, EventArgs e)
        {
            openPanel(new FMainScreen()); // panelde form açma fonksiyonumuz
            
        }

        // dikey menunun boyutu her tıklandığında durumagöre değişecek.
        private void btn_slide_Click(object sender, EventArgs e)
        {
            if(panelMenuVertical.Width == 250)
            {
                panelMenuVertical.Width = 70; // eğer menunun tamamı gözüküyorsa menuyu küçültüyoruz
            }
            else
            {
                panelMenuVertical.Width = 250; // eğer menu küçükse menuyu eski boyutuna getiriyoruz.
            }
        }

        // çarpıya tıklandığında rogram kapatılacak
        private void icon_delete_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // büyüt işaretine tıklandığında program tam boyut olacak
        // bu iconun gözükmesi için program normal boyutunda olmalı. 
        // büyük ekran yapılırsa bu icon yerine başka bir icon gözükecek.
        private void icon_maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // ekranı büyülttük.
            icon_restoreDown.Visible = true; // normal boyutuna döndürecek iconu görünür yapıyoruz.
            icon_maximize.Visible = false; // artık büyüt ikonu gözükmeyecek.
        }

        // Program normal boyutuna geçecek 
        // Bu iconun görünürlüğünü Form ekranında false yapıldı,
        // iconun gözükmesi için program büyük ekran yapılmalı.
        private void icon_restoreDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; // ekran normal boyutuna geldi
            icon_restoreDown.Visible = false; // artık bu icon gözükmeyecek.
            icon_maximize.Visible = true; // yeniden büyüt iconu görünür olacak.
        }

        // Program alta inecek
        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Programın masaüstünde istediğimiz gibi yerini değiştirmemiz için gerekli method 
        private void panelMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // yukarıda oluşturduğumuz dll yardımıyla kullanıyoruz.
            SendMessage(this.Handle, 0x112, 0xf012, 0); // kopyala + yapıştır. İçeriklerini bilmiyorum.
        }

        // Container panel de başka bir form çağırma
        private void openPanel(object formLast) // Form objesini parametre olarak yollayacğaız
        {
            if(this.panelContainer.Controls.Count > 0) // panelde bir eleman varsa üst üste gelmemesi için temizleyecez
            {
                this.panelContainer.Controls.RemoveAt(0); // veya Clear olabilir. kontrol et.
            }
            Form fl = formLast as Form; // yeni bir form oluşturuyoruz.
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill; // oluşturduğumuz formun ekranda nasıl gözükeceği 
            this.panelContainer.Controls.Add(fl); // formu control olarak ekliyoruz.
            this.panelContainer.Tag = fl;
            fl.Show(); // ekranda gösteriyoruz.
        }

        // Butonlara tıklandığında ?
        private void btn_student_Click(object sender, EventArgs e)
        {
            openPanel(new FStudent()); // ana ekranın containerinde Öğrenci formu açılacak.
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            openPanel(new FBook()); // Kitap formu açılacak.
        }

        private void btn_borrowed_Click(object sender, EventArgs e)
        {
            openPanel(new FBorrowed()); // Ödünç formu açılacak.
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            openPanel(new FMainScreen()); // Ana ekranın containerinde ana ekran için oluşturduğumuz form açılacak.
        }

        private void btn_zedgraph_Click(object sender, EventArgs e)
        {
            openPanel(new FZedgraph()); // zedgraph formu açılacak.
        }


        private void btn_main2_Click(object sender, EventArgs e)
        {
            btn_main_Click(sender, e); // bu simgeye tıkladığında ana sayfa butonuna tıklanmış gibi davran.
        }


    }
}
