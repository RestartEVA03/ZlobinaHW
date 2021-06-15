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
    public partial class main_mean_squares : Form
    {
        public main_mean_squares()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void main_mean_squares_Load(object sender, EventArgs e)
        {

        }

        private void ok_mms_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            result_mms.Clear();
            int size =  Convert.ToInt32(size_inp.Text);
            string point = point_inp.Text;
            int point_int = (int)Convert.ToInt64(point);

            char [] list_point = point.ToCharArray();
            int mid_ind;

            size_inp.Clear();
            point_inp.Clear();

            string[] result = new string[size];
            
            for (int i = 0; i < size; i++)
            {

                point_int *= point_int;

                point = Convert.ToString(point_int);

                list_point = point.ToCharArray();
                mid_ind = list_point.Length/2;
                if (mid_ind == 0) result_mms.Text +=  "!!!!!!!!!!! " + point + "!!!!!!!!";

                point = "";
                for (int j = mid_ind-2; j < mid_ind + 2; j++)
                {
                    point += list_point[j];
                }
                result[i] = "0," + point;

                point_int = (int)Convert.ToInt64(point);
            }
            for (int i = 0; i < size; i++)
            {
                double grpoint = Convert.ToDouble(result[i]);
                chart1.Series[0].Points.AddXY(i+1, grpoint);
                result_mms.Text += result[i] + " " ;
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
