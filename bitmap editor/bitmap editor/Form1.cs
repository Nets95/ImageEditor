using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmap_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog open_image = new OpenFileDialog();
        Color_Balance newRed = new Color_Balance();
        Color_Balance newGreen = new Color_Balance();
        Color_Balance newBlue = new Color_Balance();

        int[,] R = new int[5000, 5000]; // Масив для червоного кольору
        int[,] G = new int[5000, 5000]; // Масив для зеленого кольору 
        int[,] B = new int[5000, 5000]; // Масив для синього кольору

        int[,] R2 = new int[5000, 5000]; // Масив для зміненого червоного кольору
        int[,] G2 = new int[5000, 5000]; // Масив для зміненого зеленого кольору 
        int[,] B2 = new int[5000, 5000]; // Масив для зміненого синього кольору

        int height = 0;
        int width = 0; 

       
        public void Bipmap_save ()
        {
            Bitmap finish_image = new Bitmap(height, width);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    finish_image.SetPixel(i, j, Color.FromArgb(R2[i, j], G2[i, j], B2[i, j]));
                }
            }
            pictureBox1.Image = finish_image; //Вивід зображення в PictureBox
        }

        

        //Вибір зображення
        private void Open_Image_Click(object sender, EventArgs e)
        {
            if (open_image.ShowDialog () == DialogResult.OK)
            {
                pictureBox1.Location = new System.Drawing.Point(2, 2);//left,top (початок)
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; 
                pictureBox1.ImageLocation = open_image.FileName;
            }

            Bitmap start_image = new Bitmap(pictureBox1.ImageLocation); //Зчитується зображення з pictureBox1
            Color[,] color1 = new Color[start_image.Width, start_image.Height];
            for (int y = 0; y < start_image.Height; y++)
            {
                for (int x = 0; x < start_image.Width; x++)
                {
                    color1[x, y] = start_image.GetPixel(x, y);// Запис RGD в масиви
                    R[x, y] = color1[x, y].R;
                    G[x, y] = color1[x, y].G;
                    B[x, y] = color1[x, y].B;
                }
            }
            height = start_image.Height;
            width = start_image.Width;
            R2 = R;
            G2 = G;
            B2 = B;
        }

        private void Color_balance_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; //Видиміть блоку з повзунками 

           /* Bitmap start_image = new Bitmap(pictureBox1.ImageLocation); //Зчитується зображення з pictureBox1
            Color[,] color1 = new Color[start_image.Width, start_image.Height];
            for (int y = 0; y < start_image.Height; y++)
            {
                for (int x = 0; x < start_image.Width; x++)
                {
                    color1[x, y] = start_image.GetPixel(x, y);// Запис RGD в масиви
                    R[x, y] = color1[x, y].R;
                    G[x, y] = color1[x, y].G;
                    B[x, y] = color1[x, y].B;
                }
            }
            height = start_image.Height;
            width = start_image.Width;*/

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = hScrollBar1.Value.ToString();
            newRed.Red(R, hScrollBar1.Value, height, width, out R2);
            Bipmap_save();

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = hScrollBar2.Value.ToString();
            newGreen.Green(G, hScrollBar2.Value, height, width, out G2);
            Bipmap_save();

        }
   

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = hScrollBar3.Value.ToString();
            newBlue.Blue(B, hScrollBar3.Value, height, width, out B2);
            Bipmap_save();

        }

        private void Grayscale_Click(object sender, EventArgs e)
        {
            Grayscale Gray = new Grayscale();
            Gray.RGB(R, G, B, height, width, out R2, out G2, out B2);
            Bipmap_save();
            R = R2;
            G = G2;
            B = B2;

        }

        private void Negative_Click(object sender, EventArgs e)
        {
            Negative Neg = new Negative();
            Neg.RGB(R, G, B, height, width, out R2, out G2, out B2);
            Bipmap_save();
            R = R2;
            G = G2;
            B = B2;
        }

        private void Mirroring_Horizon_Click(object sender, EventArgs e)
        {
            Mirroring Hor = new Mirroring();
            Hor.Horizontally(R, G, B, height, width, out R2, out G2, out B2);
            Bipmap_save();
            R = R2;
            G = G2;
            B = B2;

        }

        private void Mirroring_Vertical_Click(object sender, EventArgs e)
        {
            Mirroring Ver = new Mirroring();
            Ver.Vertically(R, G, B, height, width, out R2, out G2, out B2);
            Bipmap_save();
            R = R2;
            G = G2;
            B = B2;
        }

        private void Binarization_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void hScrollBar_Binarization_Scroll(object sender, ScrollEventArgs e)
        {
            Binarization Bin = new Binarization();
            label7.Text = hScrollBar_Binarization.Value.ToString();
            Bin.RGB(R, G, B, hScrollBar_Binarization.Value, height, width, out R2, out G2, out B2);           
            Bipmap_save();
        }

        
    }
}
