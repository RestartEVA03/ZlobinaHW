using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb6
{
    public partial class method_of_median_products : Form
    {
        public method_of_median_products()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            textBox3.Clear();

            double point = Convert.ToDouble(textBox2.Text);
            double point2 = Convert.ToDouble(textBox1.Text);
            int size = Convert.ToInt32(textBox4.Text);
            int n = textBox2.TextLength - 2;
            double mp10 = Math.Pow(10, n);
            var generator = new Generator(Convert.ToInt32(point * mp10), Convert.ToInt32(point2 * mp10));
            for (int i = 0; i < size; i++)
            {
                double temp = Convert.ToDouble(generator.GetNumber()) / mp10;
                textBox3.Text += temp + "\t" + (i+1) + "\t";
                double grpoint = temp;
                chart4.Series[0].Points.AddXY(i + 1, grpoint);;
            }

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                chart4.Series[1].Points.AddXY(i + 1, rnd.NextDouble());
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }
        class Generator
        {
            protected double Value1 = 0;
            protected double Value2 = 0;
            public Generator(int val1, int val2)
            {
                Value1 = Convert.ToDouble(val1)/10000;
                Value2 = Convert.ToDouble(val2) / 10000;
            }
            public int GetNumber()
            {
                string step = Convert.ToString(Value1 * Value2);
                int ind = 2;
                int len_value = Value1.ToString().Length - 2;
                Value1 = Value2;
                Value2 = Convert.ToDouble(int.Parse(step.Substring(ind + 2, len_value))) / 10000;
                return Convert.ToInt32(Value2 * 10000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();

            int[] size = new int[2] { 30, 100 };
            int div_numb = 10;
            double[] count1 = new double[div_numb];
            double[] count2 = new double[div_numb];
            double[] m = new double[2] { 0, 0 };
            double[] d = new double[2] { 0, 0 };
            int n = 4;
            int ch1 = 2134;
            int ch2 = 4258;
            var generator = new Generator(ch1,ch2);
            for (int i = 0; i < size[0]; i++)
            {
                double temp = Convert.ToDouble(generator.GetNumber()) / Math.Pow(10, n);
                int t = 0;
                for (double j = 0.0; j < 1; j += 0.1)
                {
                    if (temp <= j + 0.1 & temp > j) count1[t] += 1;
                    t += 1;
                }
                m[0] += temp;
                d[0] += temp * temp;
            }

            generator = new Generator(ch1,ch2);

            for (int i = 0; i < size[1]; i++)
            {
                double temp = Convert.ToDouble(generator.GetNumber()) / Math.Pow(10, n);
                int t = 0;
                for (double j = 0.0; j < 1; j += 0.1)
                {
                    if (temp <= j + 0.1 & temp > j) count2[t] += 1;
                    t += 1;
                }
                m[1] += temp;
                d[1] += temp * temp;
            }

            for (int i = 0; i < 2; i++)
            {
                m[i] = m[i] / size[i];
                d[i] = d[i] / size[i] - (m[i] * m[i]);
            }

            for (int i = 0; i < div_numb; i++)
            {
                double grpoint1 = count1[i] / Convert.ToDouble(size[0]);
                chart1.Series[0].Points.AddXY(i + 1, grpoint1);
                double grpoint2 = count2[i] / Convert.ToDouble(size[1]);
                chart2.Series[0].Points.AddXY(i + 1, grpoint2);
            }

            textBox6.Text = " " + m[0];
            textBox7.Text = " " + d[0];
            textBox8.Text = " " + m[1];
            textBox9.Text = " " + d[1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart3.Series[0].Points.Clear();

            int size = 99;
            int g = 2;
            double[] count = new double[size + g];
            int n = 4;
            int ch1 = 2134;
            int ch2 = 4258;
            var generator = new Generator(ch1,ch2);
            for (int i = 0; i < size + g; i++)
            {
                double temp = Convert.ToDouble(generator.GetNumber()) / Math.Pow(10, n);
                count[i] = temp;
            }
            double M = 0;

            for (int i = 0; i < size / 3; i++)
            {

                for (int j = i * 3; j < (i + 1) * 3; j++)
                {
                    M += (count[j] * count[j + g]);
                }
                double R = 12 * M / ((i + 1) * 3 - g) - 3;
                double grpoint1 = R;

                chart3.Series[0].Points.AddXY(i * 10 + 10, grpoint1);
            }
        }
    }
}
