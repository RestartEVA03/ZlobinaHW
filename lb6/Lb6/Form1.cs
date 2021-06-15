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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mean_squares ms = new mean_squares();
            ms.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            method_of_median_products mmp = new method_of_median_products();
            mmp.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stirring_method sm = new stirring_method();
            sm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            linear_congruent_method lcm = new linear_congruent_method();
            lcm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Casino c = new Casino();
            c.Show();
            Hide();
        }
    }
}
