﻿using System;
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
    public partial class main_median_products : Form
    {
        public main_median_products()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }
    }
}
