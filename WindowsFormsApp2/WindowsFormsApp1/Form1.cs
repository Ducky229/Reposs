using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = 0;
            try
            {
                double.Parse(textBox1.Text.Replace(".", ","));
                double.Parse(textBox2.Text.Replace(".",","));
            }
            catch
            {
                MessageBox.Show("Недопустимые значения переменных");
                return;
            }
            double x = double.Parse(textBox1.Text.Replace(".", ","));
            double y = double.Parse(textBox2.Text.Replace(".", ","));
            textBox3.Text += "Результаты работы программы ст. Боброва А.А. " + Environment.NewLine;
            textBox3.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox3.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            if (radioButton1.Checked)
            {
                c = (Math.Pow(x, 4) - Math.Pow(y, 2)) + Math.Cos(y);// (x^2 - y) + cos (y) x - y > 0
            }
            else
              if (radioButton2.Checked)
            {
                c = (Math.Pow(y, 2) - Math.Pow(x, 4)) + Math.Tan(y);// (y  - x^2 )^2 + tg (y) x - y < 0
            }
            else
                if (radioButton3.Checked)
            {
                c = Math.Pow(x, 4) + Math.Pow(y, 2) + Math.Sin(y);
            }// (x^2)^2 + y^2 + sin(y)  x - y = 0
            textBox3.Text += "C= " + c.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }
    }
}