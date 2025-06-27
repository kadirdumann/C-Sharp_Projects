using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> sayilar = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(textBox1.Text, out sayi))
            {
                sayilar.Add(sayi);
                listBox1.Items.Add(sayi);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayilar.Sort();
            listBox2.Items.Clear();
            foreach (int sayi in sayilar)
            {
                listBox2.Items.Add(sayi);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayilar.Sort();
            sayilar.Reverse();
            listBox2.Items.Clear();
            foreach (int sayi in sayilar)
            {
                listBox2.Items.Add(sayi);
            }
        }
    }
}
