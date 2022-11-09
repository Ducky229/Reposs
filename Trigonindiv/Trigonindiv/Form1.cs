using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonindiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,74e-2";
            textBox2.Text = "-0,825";
            textBox3.Text = "0,16e2";
        }
        private void Formula ()
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text = "лаб. раб. №2 ст. гр. 22919/3 Боброва А.А";
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            double up = 1 + Math.Pow(Math.Sin(x + y),2);// 1 + sin^2(x+y)
                                                                                        //|        2y     |
            double down = Math.Abs(x - ((2 * y)/(1 + (Math.Pow(x,2) * Math.Pow(y,2)))));//|х - ---------  |
                                                                                        //|   1+x^2*y^2   |
                                                                 //            1
            double final = Math.Sqrt(Math.Cos(Math.Atan(1 / z)));//Cos^2(Arctg(-))
                                                                 //            z
            double right = Math.Pow(x,Math.Abs(y));//x^|y|
            //Прокомментируй если нужно убрать отладку
            double db1 = Math.Pow(y,2);
            //textBox4.Text += Environment.NewLine + "Отладка math " + db1.ToString();
            textBox4.Text += Environment.NewLine + "Отладка up " + up.ToString();
            textBox4.Text += Environment.NewLine + "Отладка down " + down.ToString();
            textBox4.Text += Environment.NewLine + "Отладка right " + right.ToString();
            textBox4.Text += Environment.NewLine + "Отладка final " + final.ToString();
            double v = ((up / down) * right) + final;
            textBox4.Text += Environment.NewLine + "Результат V = " + v.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Formula();
        }
    }
}
