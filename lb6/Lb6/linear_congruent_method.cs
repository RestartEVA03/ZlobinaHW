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
    public partial class linear_congruent_method : Form
    {
        public linear_congruent_method()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int M = Convert.ToInt32(textBox3.Text);
            int R = Convert.ToInt32(textBox4.Text);
            int size = Convert.ToInt32(textBox5.Text);
            int n = textBox1.TextLength;

            for (int i = 0; i < size; i++)
            {
                R = (a * R + b) % M;
                textBox6.Text += R + "\n" + i + "\n";
                int grpoint = R;
                chart4.Series[0].Points.AddXY(i + 1, grpoint);
            }

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {

                chart4.Series[1].Points.AddXY(i + 1, rnd.Next(M));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void linear_congruent_method_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();

            int[] size = new int[2] { 100, 10000 };
            int div_numb = 10;
            double[,] count = new double[2, div_numb];
            double[] m_arr = new double[2] { 0, 0 };
            double[] d = new double[2] { 0, 0 };
            int x = 7;
            int a = 106;
            int b = 1283;
            int m = 6000;
            for (int s = 0; s < 2; s++)
            {
                for (int i = 0; i < size[s]; i++)
                {
                    x = (a * x + b) % m;
                    int t = 0;
                    double temp = Convert.ToDouble(x);
                    for (int j = 0; j < 6000; j += 600)
                    {
                        if (temp <= j + 600 & temp > j) count[s,t] += 1;
                        t += 1;
                    }
                    m_arr[s] += Convert.ToDouble(temp) / m;
                    d[s] += Convert.ToDouble(temp) / m * Convert.ToDouble(temp) / m;
                }
                m_arr[s] = m_arr[s] / size[s];
                d[s] = d[s] / size[s] - (m_arr[s] * m_arr[s]);
            }


                for (int i = 0; i < div_numb; i++)
                {
                    double grpoint1 = count[0,i] / Convert.ToDouble(size[0]);
                    chart1.Series[0].Points.AddXY(i + 1, grpoint1);
                    double grpoint2 = count[1,i] / Convert.ToDouble(size[1]);
                    chart2.Series[0].Points.AddXY(i + 1, grpoint2);
                }

            textBox13.Text = " " + m_arr[0];
            textBox7.Text = " " + d[0];
            textBox8.Text = " " + d[1];
            textBox9.Text = " " + m_arr[1];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart3.Series[0].Points.Clear();

            int size = 1000;
            int g = 5;
            double[] count = new double[size + g];
            int x = 7;
            int a = 106;
            int b = 1283;
            int m = 6000;
            for (int i = 0; i < size + g; i++)
            {
                x = (a * x + b) % m;
                count[i] = Convert.ToDouble(x)/6000;
            }
            double M = 0;

            for (int i = 0; i < size / 10; i++)
            {

                for (int j = i * 10; j < (i + 1) * 10; j++)
                {
                    M += (count[j] * count[j + g]);
                }
                double R = 12 * M / ((i + 1) * 10 - g) - 3;
                double grpoint1 = R;

                chart3.Series[0].Points.AddXY(i * 10 + 10, grpoint1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }
    }
}
