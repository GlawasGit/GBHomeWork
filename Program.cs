using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3,3];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = 3;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[row, col] = i + 1;
                if (--gran == 0)
                {
                    gran = 3 * (dirChanges % 2) + 3 * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
