using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitmap_editor
{
    class Mirroring
    {
        int[,] RR = new int[3000, 3000];
        int[,] GG = new int[3000, 3000];
        int[,] BB = new int[3000, 3000];

        public void Horizontally(int[,] R, int[,] G, int[,] B, int height, int width, out int[,] R1, out int[,] G1, out int[,] B1)
        {

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    RR[i, j] = R[(width - 1) - i, j]; //Перенесення червоного
                    GG[i, j] = G[(width - 1) - i, j]; //Перенесення зеленого
                    BB[i, j] = B[(width - 1) - i, j]; //Перенесення синього

                }
            }

            R1 = RR;
            G1 = GG;
            B1 = BB;
            

        }

        public void Vertically(int[,] R, int[,] G, int[,] B, int height, int width, out int[,] R1, out int[,] G1, out int[,] B1)
        {

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    RR[i, j] = R[i, (width - 1) - j]; //Перенесення червоного
                    GG[i, j] = G[i, (width - 1) - j]; //Перенесення зеленого
                    BB[i, j] = B[i, (width - 1) - j]; //Перенесення синього
                }
            }
            R1 = RR;
            G1 = GG;
            B1 = BB;
        }
    }
}
