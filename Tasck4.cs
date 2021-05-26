//using System;

//namespace ConsoleApp5
//{
//    class Tasck1
//    {
//        static void Main(string[] args)
//        {
//            string[,] battle = new string[10, 10]
//            {
//                {"X", "X", "O", "X", "O", "O", "X", "X", "X", "X"},
//                {"O", "O", "O", "X", "O", "O", "O", "O", "O", "O"},
//                {"O", "O", "O", "X", "O", "O", "O", "O", "O", "X"},
//                {"O", "O", "O", "X", "O", "O", "O", "O", "O", "X"},
//                {"O", "X", "O", "O", "O", "O", "O", "O", "O", "O"},
//                {"O", "X", "O", "O", "O", "O", "O", "O", "O", "O"},
//                {"O", "X", "O", "O", "O", "O", "X", "O", "O", "O"},
//                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
//                {"O", "O", "O", "X", "O", "X", "O", "O", "X", "O"},
//                {"X", "O", "O", "O", "O", "O", "O", "O", "X", "O"},
//            };
//            for (int i = 0; i < battle.GetLength(0); i++)
//            {
//                for (int j = 0; j < battle.GetLength(1); j++)
//                {
//                    Console.Write($"{battle[i, j]}  ");
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//        }
//    }
//}
