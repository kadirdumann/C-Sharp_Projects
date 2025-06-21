using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result1 = Convert.ToInt32(comboBox1.SelectedItem) & Convert.ToInt32(comboBox8.SelectedItem);
            int result2 = Convert.ToInt32(comboBox2.SelectedItem) & Convert.ToInt32(comboBox7.SelectedItem);
            int result3 = Convert.ToInt32(comboBox3.SelectedItem) & Convert.ToInt32(comboBox6.SelectedItem);
            int result4 = Convert.ToInt32(comboBox4.SelectedItem) & Convert.ToInt32(comboBox5.SelectedItem);

            label5.Text = result1.ToString();
            label6.Text = result2.ToString();
            label7.Text = result3.ToString();
            label8.Text = result4.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int comboBox1Value = Convert.ToInt32(comboBox1.SelectedItem);
            int comboBox2Value = Convert.ToInt32(comboBox2.SelectedItem);
            int comboBox3Value = Convert.ToInt32(comboBox3.SelectedItem);
            int comboBox4Value = Convert.ToInt32(comboBox4.SelectedItem);

            int comboBox8Value = Convert.ToInt32(comboBox8.SelectedItem);
            int comboBox7Value = Convert.ToInt32(comboBox7.SelectedItem);
            int comboBox6Value = Convert.ToInt32(comboBox6.SelectedItem);
            int comboBox5Value = Convert.ToInt32(comboBox5.SelectedItem);

            int result1 =  comboBox1Value |  comboBox8Value;
            int result2 =  comboBox2Value |  comboBox7Value;
            int result3 =  comboBox3Value |  comboBox6Value;
            int result4 =  comboBox4Value |  comboBox5Value;

            label5.Text = result1.ToString();
            label6.Text = result2.ToString();
            label7.Text = result3.ToString();
            label8.Text = result4.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";

            comboBox1.SelectedItem = "0";
            comboBox2.SelectedItem = "0";
            comboBox3.SelectedItem = "0";
            comboBox4.SelectedItem = "0";
            comboBox5.SelectedItem = "0";
            comboBox6.SelectedItem = "0";
            comboBox7.SelectedItem = "0";
            comboBox8.SelectedItem = "0";
        }

    }
}
