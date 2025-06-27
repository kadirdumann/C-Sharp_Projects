using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siir siir = new Siir();
            BestelenenSiir bestelenenSiir = new BestelenenSiir();

            bestelenenSiir.yazar = textBox1.Text;
            bestelenenSiir.siirAdi = textBox2.Text;
            bestelenenSiir.satirSayisi = Convert.ToInt32(textBox3.Text);
            bestelenenSiir.besteleyenKisi = textBox4.Text;
            bestelenenSiir.bestelendigiTarih = Convert.ToInt32(textBox5.Text);

            if (bestelenenSiir.yazar == "") 
            {
                bestelenenSiir.yazar = "Anonim";
            }

            listBox1.Items.Add(bestelenenSiir.yazar);
            listBox1.Items.Add(bestelenenSiir.siirAdi);
            listBox1.Items.Add(bestelenenSiir.satirSayisi.ToString());
            listBox1.Items.Add(bestelenenSiir.besteleyenKisi);
            listBox1.Items.Add(bestelenenSiir.bestelendigiTarih.ToString());
        }

    }
}
