using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Textbox'lardan veri alınır
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int sayi4 = Convert.ToInt32(textBox4.Text);
            int sayi5 = Convert.ToInt32(textBox5.Text);

            // Textbox'tan veri alınır
            int toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;


            // Yüzde hesaplaması yapılır
            double yuzde1 = (double)sayi1 / toplam * 100;
            double yuzde2 = (double)sayi2 / toplam * 100;
            double yuzde3 = (double)sayi3 / toplam * 100;
            double yuzde4 = (double)sayi4 / toplam * 100;
            double yuzde5 = (double)sayi5 / toplam * 100;

            // Chart'a veri eklenir
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Series["Series1"].Points.AddXY("Fatura %" + yuzde1.ToString("N2"), yuzde1);
            chart1.Series["Series1"].Points.AddXY("Kira %" + yuzde2.ToString("N2"), yuzde2);
            chart1.Series["Series1"].Points.AddXY("Gıda %" + yuzde3.ToString("N2"), yuzde3);
            chart1.Series["Series1"].Points.AddXY("Eğitim %" + yuzde4.ToString("N2"), yuzde4);
            chart1.Series["Series1"].Points.AddXY("Diğer %" + yuzde5.ToString("N2"), yuzde5);
            chart1.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            // Textbox'lardan veri alınır
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);
            int sayi4 = Convert.ToInt32(textBox4.Text);
            int sayi5 = Convert.ToInt32(textBox5.Text);

            // Textbox'tan veri alınır
            int toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;


            // Yüzde hesaplaması yapılır
            double yuzde1 = (double)sayi1 / toplam * 100;
            double yuzde2 = (double)sayi2 / toplam * 100;
            double yuzde3 = (double)sayi3 / toplam * 100;
            double yuzde4 = (double)sayi4 / toplam * 100;
            double yuzde5 = (double)sayi5 / toplam * 100;

            string secilenDeger = comboBox1.SelectedItem.ToString();
            
            switch (secilenDeger)
            {
                case "Fatura": 
                    label6.Text = secilenDeger + " %" + yuzde1;
                    break;
                case "Kira":
                    label6.Text = secilenDeger + " %" + yuzde2;
                    break;
                case "Gıda":
                    label6.Text = secilenDeger + " %" + yuzde3;
                    break;
                case "Eğitim":
                    label6.Text = secilenDeger + " %" + yuzde4;
                    break;
                case "Diğer":
                    label6.Text = secilenDeger + " %" + yuzde5;
                    break;
                default:
                    label6.Text = "Hatalı Değer";
                    break;
            }
        }
    }
}
