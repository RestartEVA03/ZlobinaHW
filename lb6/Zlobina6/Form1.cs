using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zlobina6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mean_squares_method_Click(object sender, EventArgs e)
        {
            main_mean_squares mms = new main_mean_squares();
            mms.Show();
            Hide();
        }

        private void method_of_median_products_Click(object sender, EventArgs e)
        {
            main_median_products mmp = new main_median_products();
            mmp.Show();
            Hide();
        }

        private void stirring_method_Click(object sender, EventArgs e)
        {
            main_stirring_method msm = new main_stirring_method();
            msm.Show();
            Hide();
        }

        private void linear_congruent_method_Click(object sender, EventArgs e)
        {
            main_linear_congruent mlc = new main_linear_congruent();
            mlc.Show();
            Hide();
        }

        private void random_Click(object sender, EventArgs e)
        {
            main_random mr = new main_random();
            mr.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
