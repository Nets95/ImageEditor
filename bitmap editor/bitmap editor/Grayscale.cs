using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap_editor
{
    class Grayscale
    {
        public void RGB (int[,] R, int[,] G, int[,] B, int height, int width, out int[,] R1, out int[,] G1, out int[,] B1)
        {
            int[,] Y = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Y[i, j] = Convert.ToInt32(0.3 * R[i, j] + 0.6 * G[i, j] + 0.1 * B[i, j]);
                    if (Y[i, j] > 255)
                        Y[i, j] = 255;
                    if (Y[i, j] < 0)
                        Y[i, j] = 0;
                }
            }
            G1 = Y;
            R1 = Y;
            B1 = Y;
        }
    }
}
