using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap_editor
{
    class Color_Balance
    {
        int[,] Y = new int[3000, 3000];

        public void Red (int [,] R, int difference, int height, int width, out int [,] R1)
        {
            for (int i=0; i< height; i++)
            {
                for (int j = 0; j< width; j++)
                {
                    Y[i, j] = R[i, j] + difference;
                    if (Y[i, j] > 255)
                        Y[i, j] = 255;
                    if (Y[i, j] < 0)
                        Y[i, j] = 0;
                }
            }
            R1 = Y;
        }

        public void Green(int[,] G, int difference, int height, int width, out int[,] G1)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Y[i, j] = G[i, j] + difference;
                    if (Y[i, j] > 255)
                        Y[i, j] = 255;
                    if (Y[i, j] < 0)
                        Y[i, j] = 0;
                }
            }
            G1=Y;
        }


        public void Blue (int[,] B, int difference, int height, int width, out int [,] B1)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Y[i, j] = B[i, j] + difference; 
                    if (Y[i, j] > 255)
                        Y[i, j] = 255;
                    if (Y[i, j] < 0)
                        Y[i, j] = 0;
                }
            }
            B1 = Y;
        }
    }
}
