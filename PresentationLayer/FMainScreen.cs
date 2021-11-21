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
using System.Configuration;

namespace PresentationLayer
{
    public partial class FMainScreen : Form
    {
        public FMainScreen()
        {
            InitializeComponent();
        }

        // ana ekran içerisinde form çağıracaz
        private void openPanel(object formLast)
        {
            if (this.panel_container.Controls.Count > 0)
            {
                this.panel_container.Controls.RemoveAt(0); // veya Clear olabilir.
            }
            Form fl = formLast as Form;
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill; // oluşturduğumuz formun ekranda nasıl gözükeceği 
            this.panel_container.Controls.Add(fl);
            this.panel_container.Tag = fl;
            fl.Show();
        }

        //public static String connectionString = ConfigurationManager.ConnectionStrings["AccessConnectionString"].ConnectionString;
        // kullanacağımız iş katmanı metotları
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());
        
        // ana ekranda kitapları listelecez
        private void kitap_goster()
        {
            if (businessManager.kitap_sayisi_ogren() == 0)
            {
                label_bilgilendirme.Text = "Kütüphanede kitap yok.";
            }
            else
            {
                dataGrid_student.DataSource = businessManager.kitap_listele().Tables[0];
                dataGrid_student.Columns[0].HeaderText = "Kitap ID";
                dataGrid_student.Columns[1].HeaderText = "Kitap İsmi";
                dataGrid_student.Columns[2].HeaderText = "Kitap Türü";
                dataGrid_student.Columns[3].HeaderText = "Kitap Yazarı";
                dataGrid_student.Columns[4].HeaderText = "Kitap Yayınevi";
                dataGrid_student.Columns[5].HeaderText = "Kitap Sayfası";
                dataGrid_student.Columns[6].HeaderText = "Kitap Adeti";
                // listele ve kolon isimlerini değiştir
            }
        }

        // bu form yüklenirken kolon rengi değişecek, zedgraph formu çağırılacak
        // kütüphanedeki kitap sayısı ekranda yazacak.
        // kitaplar listelenecek
        private void FMainScreen_Load(object sender, EventArgs e)
        {
            dataGrid_student.EnableHeadersVisualStyles = false;
            dataGrid_student.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dataGrid_student.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
            openPanel(new FZedgraph());
            
            label_bilgilendirme.Text = "Kütüphanedeki kitap sayısı: " + businessManager.kitap_sayisi_ogren().ToString();

            kitap_goster();
            dataGrid_student.ClearSelection(); // başlangıçta seçili gelmeyecek.
        }

        // kolon sıralamaları yapılmayacak.
        private void dataGrid_student_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dataGrid_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
