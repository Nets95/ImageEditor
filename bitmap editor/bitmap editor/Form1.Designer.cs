namespace bitmap_editor
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Open_Image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Color_balance = new System.Windows.Forms.Button();
            this.Grayscale = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.Mirroring_Horizon = new System.Windows.Forms.Button();
            this.Mirroring_Vertical = new System.Windows.Forms.Button();
            this.Binarization = new System.Windows.Forms.Button();
            this.hScrollBar_Binarization = new System.Windows.Forms.HScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Open_Image
            // 
            this.Open_Image.Location = new System.Drawing.Point(554, 13);
            this.Open_Image.Name = "Open_Image";
            this.Open_Image.Size = new System.Drawing.Size(484, 41);
            this.Open_Image.TabIndex = 0;
            this.Open_Image.Text = "Вибрати\r\nзображення";
            this.Open_Image.UseVisualStyleBackColor = true;
            this.Open_Image.Click += new System.EventHandler(this.Open_Image_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(49, 25);
            this.hScrollBar1.Minimum = -100;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(264, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.LargeChange = 1;
            this.hScrollBar2.Location = new System.Drawing.Point(49, 59);
            this.hScrollBar2.Minimum = -100;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(264, 17);
            this.hScrollBar2.TabIndex = 3;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.LargeChange = 1;
            this.hScrollBar3.Location = new System.Drawing.Point(49, 97);
            this.hScrollBar3.Minimum = -100;
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(264, 17);
            this.hScrollBar3.TabIndex = 4;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.hScrollBar3);
            this.groupBox1.Controls.Add(this.hScrollBar2);
            this.groupBox1.Location = new System.Drawing.Point(554, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 136);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "BLUE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RED";
            // 
            // Color_balance
            // 
            this.Color_balance.Location = new System.Drawing.Point(947, 60);
            this.Color_balance.Name = "Color_balance";
            this.Color_balance.Size = new System.Drawing.Size(91, 37);
            this.Color_balance.TabIndex = 6;
            this.Color_balance.Text = "Баланс кольорів";
            this.Color_balance.UseVisualStyleBackColor = true;
            this.Color_balance.Click += new System.EventHandler(this.Color_balance_Click);
            // 
            // Grayscale
            // 
            this.Grayscale.Location = new System.Drawing.Point(554, 251);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(91, 37);
            this.Grayscale.TabIndex = 7;
            this.Grayscale.Text = "Градації сірого";
            this.Grayscale.UseVisualStyleBackColor = true;
            this.Grayscale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(651, 251);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(91, 37);
            this.Negative.TabIndex = 8;
            this.Negative.Text = "Інверсія";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.Negative_Click);
            // 
            // Mirroring_Horizon
            // 
            this.Mirroring_Horizon.Location = new System.Drawing.Point(554, 294);
            this.Mirroring_Horizon.Name = "Mirroring_Horizon";
            this.Mirroring_Horizon.Size = new System.Drawing.Size(91, 58);
            this.Mirroring_Horizon.TabIndex = 9;
            this.Mirroring_Horizon.Text = "Дзеркальне відображення горизонтально";
            this.Mirroring_Horizon.UseVisualStyleBackColor = true;
            this.Mirroring_Horizon.Click += new System.EventHandler(this.Mirroring_Horizon_Click);
            // 
            // Mirroring_Vertical
            // 
            this.Mirroring_Vertical.Location = new System.Drawing.Point(651, 294);
            this.Mirroring_Vertical.Name = "Mirroring_Vertical";
            this.Mirroring_Vertical.Size = new System.Drawing.Size(91, 58);
            this.Mirroring_Vertical.TabIndex = 10;
            this.Mirroring_Vertical.Text = "Дзеркальне відображення вертикально";
            this.Mirroring_Vertical.UseVisualStyleBackColor = true;
            this.Mirroring_Vertical.Click += new System.EventHandler(this.Mirroring_Vertical_Click);
            // 
            // Binarization
            // 
            this.Binarization.Location = new System.Drawing.Point(947, 210);
            this.Binarization.Name = "Binarization";
            this.Binarization.Size = new System.Drawing.Size(91, 37);
            this.Binarization.TabIndex = 11;
            this.Binarization.Text = "Бінаризація";
            this.Binarization.UseVisualStyleBackColor = true;
            this.Binarization.Click += new System.EventHandler(this.Binarization_Click);
            // 
            // hScrollBar_Binarization
            // 
            this.hScrollBar_Binarization.LargeChange = 1;
            this.hScrollBar_Binarization.Location = new System.Drawing.Point(49, 16);
            this.hScrollBar_Binarization.Maximum = 255;
            this.hScrollBar_Binarization.Name = "hScrollBar_Binarization";
            this.hScrollBar_Binarization.Size = new System.Drawing.Size(264, 17);
            this.hScrollBar_Binarization.TabIndex = 12;
            this.hScrollBar_Binarization.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Binarization_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.hScrollBar_Binarization);
            this.groupBox2.Location = new System.Drawing.Point(554, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 46);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Поріг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Binarization);
            this.Controls.Add(this.Mirroring_Vertical);
            this.Controls.Add(this.Mirroring_Horizon);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.Color_balance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Open_Image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Open_Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Color_balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Grayscale;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Mirroring_Horizon;
        private System.Windows.Forms.Button Mirroring_Vertical;
        private System.Windows.Forms.Button Binarization;
        private System.Windows.Forms.HScrollBar hScrollBar_Binarization;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

