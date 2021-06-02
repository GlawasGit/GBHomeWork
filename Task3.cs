//using System;
//using System.IO;

//namespace ConsoleApp7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string numbers = Console.ReadLine();
//            string[] numbersArr = numbers.Split();
//            byte[] byteArr = new byte[100];
//            for (int i = 0; i < numbersArr.Length; i++)
//            {
//                byteArr[i] = Convert.ToByte(numbersArr[i]);
//            }
//            File.WriteAllBytes("bytes.bin", byteArr);
//        }
//    }
//}
