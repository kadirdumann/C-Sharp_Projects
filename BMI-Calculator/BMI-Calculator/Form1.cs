using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ad = nameBox.Text;
            string soyad = surnameBox.Text;
            double boy = Convert.ToDouble(lengthBox.Text); // textbox'tan boy değerini al
            double kilo = Convert.ToDouble(weightBox.Text); // textbox'tan kilo değerini al
            string cinsiyet = comboBox.Items.Count.ToString();

            //double vke = kilo / (boy * boy); // vücut kitle indeksi hesabı
            double vke = kilo / ((boy / 100.0) * (boy / 100.0));

            // Vücut kitle endeksi yorumu
            string yorum = "";
            if (cinsiyet == "Bay")
            {
                if (vke < 20.7)
                {
                    yorum = "Zayıf";
                }
                else if (vke >= 20.7 && vke < 26.4)
                {
                    yorum = "Normal";
                }
                else
                {
                    yorum = "Fazla Kilolu";
                }

            }
            else
            {
                if (vke < 19.1)
                {
                    yorum = "Zayıf";
                }
                else if (vke >= 19.1 && vke < 25.8)
                {
                    yorum = "Normal";
                }
                else
                {
                    yorum = "Fazla Kilolu";
                }
            }
            label2.Text = yorum;

            listBox1.Items.Add(ad + " " + soyad + " - " + vke.ToString("F") + " - " + label2.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
