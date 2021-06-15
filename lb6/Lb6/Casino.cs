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
    public partial class Casino : Form
    {
        int balance = 10000;
        public Casino()
        {
            InitializeComponent();
            label3.Text = " " + balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = " " + balance;

            int stavka = Convert.ToInt32(textBox1.Text);
            int a = 106;
            int b = 1083;
            int M = 6000;
            var unixTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            int R = Convert.ToInt32(unixTime);
            int flag1 = 0;

            for (int i = 0; i <= 1000; i++)
            {

                if (i == 1)
                {
                    R = (a * R + b) % M;
                    if (R > (M / 2)) { pictureBox1.Image = Image.FromFile("D:/lb7scr/seven.jpg"); flag1++; }
                    else pictureBox1.Image = Image.FromFile("D:/lb7scr/sad.jpg");
                }
                if (i == 10)
                {
                    R = (a * R + b) % M;
                    if (R > (M / 2)) {pictureBox2.Image = Image.FromFile("D:/lb7scr/seven.jpg");flag1++; }
                    else pictureBox2.Image = Image.FromFile("D:/lb7scr/sad.jpg");
                }
                if (i == 100)
                {
                    R = (a * R + b) % M;
                    if (R > (M / 2)) {pictureBox3.Image = Image.FromFile("D:/lb7scr/seven.jpg"); flag1++; }
                    else pictureBox3.Image = Image.FromFile("D:/lb7scr/sad.jpg");
                }
                if (i == 1000)
                {
                    R = (a * R + b) % M;
                    if (R > (M / 2)) {pictureBox4.Image = Image.FromFile("D:/lb7scr/seven.jpg"); flag1++; }
                else pictureBox4.Image = Image.FromFile("D:/lb7scr/sad.jpg");
                }
                R = (a * R + b) % M;
            }

            if (flag1 == 4)
            {
                balance += stavka*4;
            }
            if (flag1 == 3 )
            {
                balance += stavka*2;
            }
            if (flag1 == 1)
            {
                balance -= stavka*2;
            }
            if (flag1 == 0)
            {
                balance -= stavka *4;
            }

            label3.Text = " " + balance;
        }
    }
}
