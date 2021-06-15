
namespace Zlobina6
{
    partial class main_mean_squares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.size_inp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.point_inp = new System.Windows.Forms.TextBox();
            this.ok_mms = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.result_mms = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 85);
            this.panel2.TabIndex = 2;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(15, 18);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 27);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(751, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Трефилов И.В.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите кол-во точек:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 69);
            this.panel1.TabIndex = 3;
            // 
            // size_inp
            // 
            this.size_inp.Location = new System.Drawing.Point(390, 118);
            this.size_inp.Name = "size_inp";
            this.size_inp.Size = new System.Drawing.Size(100, 20);
            this.size_inp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите число с четной разрядностью (0,...):";
            // 
            // point_inp
            // 
            this.point_inp.Location = new System.Drawing.Point(390, 191);
            this.point_inp.Name = "point_inp";
            this.point_inp.Size = new System.Drawing.Size(100, 20);
            this.point_inp.TabIndex = 7;
            // 
            // ok_mms
            // 
            this.ok_mms.Location = new System.Drawing.Point(340, 251);
            this.ok_mms.Name = "ok_mms";
            this.ok_mms.Size = new System.Drawing.Size(186, 29);
            this.ok_mms.TabIndex = 8;
            this.ok_mms.Text = "Готово";
            this.ok_mms.UseVisualStyleBackColor = true;
            this.ok_mms.Click += new System.EventHandler(this.ok_mms_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(390, 311);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Случайное число";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(457, 245);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Метод срединных квадратов";
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // result_mms
            // 
            this.result_mms.Location = new System.Drawing.Point(105, 311);
            this.result_mms.Multiline = true;
            this.result_mms.Name = "result_mms";
            this.result_mms.Size = new System.Drawing.Size(219, 245);
            this.result_mms.TabIndex = 10;
            // 
            // main_mean_squares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.result_mms);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ok_mms);
            this.Controls.Add(this.point_inp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.size_inp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "main_mean_squares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_mean_squares";
            this.Load += new System.EventHandler(this.main_mean_squares_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox size_inp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox point_inp;
        private System.Windows.Forms.Button ok_mms;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox result_mms;
    }
}