using System;

namespace ConsoleApp5
{
    class Tasck1
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int iLast = matrix.GetLength(0) - 1, jLast = matrix.GetLength(1) - 1;
            for (int i = 0; i <= iLast; i++)
            {
                matrix[i, i] = 1;
                matrix[i, iLast - i] = 1;

                for (var j = 0; j <= jLast; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }

    }
}
