
namespace Zlobina6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mean_squares_method = new System.Windows.Forms.Button();
            this.method_of_median_products = new System.Windows.Forms.Button();
            this.linear_congruent_method = new System.Windows.Forms.Button();
            this.stirring_method = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 82);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "Random number generator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-7, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 85);
            this.panel2.TabIndex = 1;
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
            // mean_squares_method
            // 
            this.mean_squares_method.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mean_squares_method.Location = new System.Drawing.Point(200, 131);
            this.mean_squares_method.Name = "mean_squares_method";
            this.mean_squares_method.Size = new System.Drawing.Size(480, 53);
            this.mean_squares_method.TabIndex = 2;
            this.mean_squares_method.Text = "Метод срединных квадратов";
            this.mean_squares_method.UseVisualStyleBackColor = true;
            this.mean_squares_method.Click += new System.EventHandler(this.mean_squares_method_Click);
            // 
            // method_of_median_products
            // 
            this.method_of_median_products.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method_of_median_products.Location = new System.Drawing.Point(200, 219);
            this.method_of_median_products.Name = "method_of_median_products";
            this.method_of_median_products.Size = new System.Drawing.Size(480, 53);
            this.method_of_median_products.TabIndex = 3;
            this.method_of_median_products.Text = "Метод срединных произведений";
            this.method_of_median_products.UseVisualStyleBackColor = true;
            this.method_of_median_products.Click += new System.EventHandler(this.method_of_median_products_Click);
            // 
            // linear_congruent_method
            // 
            this.linear_congruent_method.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linear_congruent_method.Location = new System.Drawing.Point(200, 390);
            this.linear_congruent_method.Name = "linear_congruent_method";
            this.linear_congruent_method.Size = new System.Drawing.Size(480, 53);
            this.linear_congruent_method.TabIndex = 5;
            this.linear_congruent_method.Text = "Линейный конгруэнтный метод";
            this.linear_congruent_method.UseVisualStyleBackColor = true;
            this.linear_congruent_method.Click += new System.EventHandler(this.linear_congruent_method_Click);
            // 
            // stirring_method
            // 
            this.stirring_method.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stirring_method.Location = new System.Drawing.Point(200, 306);
            this.stirring_method.Name = "stirring_method";
            this.stirring_method.Size = new System.Drawing.Size(480, 53);
            this.stirring_method.TabIndex = 4;
            this.stirring_method.Text = "Метод перемешивания";
            this.stirring_method.UseVisualStyleBackColor = true;
            this.stirring_method.Click += new System.EventHandler(this.stirring_method_Click);
            // 
            // random
            // 
            this.random.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random.Location = new System.Drawing.Point(200, 473);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(480, 53);
            this.random.TabIndex = 6;
            this.random.Text = "Random( )\r\n";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.random);
            this.Controls.Add(this.linear_congruent_method);
            this.Controls.Add(this.stirring_method);
            this.Controls.Add(this.method_of_median_products);
            this.Controls.Add(this.mean_squares_method);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mean_squares_method;
        private System.Windows.Forms.Button method_of_median_products;
        private System.Windows.Forms.Button linear_congruent_method;
        private System.Windows.Forms.Button stirring_method;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button button1;
    }
}

