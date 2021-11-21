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
using ZedGraph;

namespace PresentationLayer
{
    public partial class FZedgraph : Form
    {
        public FZedgraph()
        {
            InitializeComponent();
        }
        // çalışmasını istediğimiz iş katmanı metotları.
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=AccessDB.mdb"), new StudentComplexCheckService(), new BookAllCheckService(), new BorrowedDeleteCheckService());

        public void graphOlustur(ZedGraphControl zg1)
        { // kopyala yapıştır ile sütun grafiği oluşturan zedGraph kodlarını programa uyarladım.
            GraphPane myPane = zg1.GraphPane;


            // Oluştudruğum  sütun değerleri
            double[] y =  { businessManager.kitap_sayisi_ogren() };
            double[] y2 = { businessManager.ogrenci_sayisi_ogren() };
            double[] y3 = { businessManager.odunc_alinan_kitap_sayisi() };
            double[] y4 = { businessManager.odunc_teslim_edilmeyen_kitap_sayisi() };
            


            // Yukarıda yazmasını istediğim sütunların açıklaması.

            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = myPane.AddBar("Kitap Çeşiti", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White,
                                                        Color.Red);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = myPane.AddBar("Öğrenci Sayısı", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White,
                                                        Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            myBar = myPane.AddBar("Ödünç Alınan Kitap Sayısı", null, y3, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White,
                                                        Color.Green);
            // Generate a green bar with "Curve 4" in the legend
            myBar = myPane.AddBar("Teslim Edilmeyen Kitap Sayısı", null, y4, Color.Yellow);
            myBar.Bar.Fill = new Fill(Color.Yellow, Color.White,
                                                        Color.Yellow);

            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            //myPane.XAxis.Scale.TextLabels = labels;

            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            //myPane.Chart.Fill = new Fill(Color.White,
            //      Color.FromArgb(255, 255, 166), 90F);
            myPane.Chart.Fill = new Fill(Color.WhiteSmoke, Color.WhiteSmoke);
            myPane.Fill = new Fill(Color.WhiteSmoke);
            myPane.Title.Text = "Kütüphane Bilgileri (Grafik)";
            myPane.XAxis.Title.Text = "Kütüphane Analizi";
            myPane.YAxis.Title.Text = "Sayısal Değerler";
            myPane.Border.IsVisible = false;
            myPane.Legend.Position = LegendPos.TopCenter;
            myPane.Title.IsVisible = false;

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zg1.AxisChange();

        }

        private void FZedgraph_Load(object sender, EventArgs e)
        {
            graphOlustur(zedGraph1); // oluşturduğumuz fonksiyonu bu form açılırken çağırıyoruz.
        }

        private void zedGraph1_Load(object sender, EventArgs e)
        {

        }
    }
}
