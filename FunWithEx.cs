using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace ConsoleApp8
{

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[,] mass = new string[4, 4]
               {
                {"1","2","3","4",},
                {"1","2","3","ups",},
                {"1","2","3","4",},
                {"1","2","3","4",}
               };

            try
            {
                try
                {
                    sum = ExFun(mass);
                }
                catch (MyArraySizeException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            catch (MyArrayDataException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine(sum);
        }

        public static int ExFun(string[,] mass)
        {
            int sum = 0;
            if (mass.GetLength(0) > 4)
            {
                throw new MyArraySizeException();
            }
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                if (mass.GetLength(1) != 4)
                {
                    throw new MyArraySizeException();
                }
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    try
                    {
                        sum += Int32.Parse(mass[i, j]);
                    }
                    catch (Exception)
                    {
                        throw new MyArrayDataException(i, j);
                    }
                }                
            }
            return sum;
        }
    }
}

       