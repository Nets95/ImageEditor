using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap_editor
{
    class Negative
    {
        public void RGB(int[,] R, int[,] G, int[,] B, int height, int width, out int[,] R1, out int[,] G1, out int[,] B1)
        {
            R1 = R;
            G1 = G;
            B1 = B;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    R1[i, j] = 255 - R[i, j]; //Інверсія червоного
                    G1[i, j] = 255 - G[i, j]; //Інверсія зеленого
                    B1[i, j] = 255 - B[i, j]; //Інверсія синього
                }
            }
            
        }
    }
}
