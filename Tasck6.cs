using System;

namespace ConsoleApp4
{
    class Tasck6
    {
        [Flags]
        public enum Day
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000
        }
        static void Main(string[] args)
            
        {
            Day office1 = Day.Tuesday | Day.Wednesday | Day.Thursday | Day.Friday;
            Day office2 = Day.Saturday | Day.Sunday | Day.Monday;

            Day office1Work = (Day)0b_0011110;
            Day office2Work = (Day)0b_1100001;

            Day shift1 = office1Work & office1;
            Day shift2 = office2Work & office2;

            bool isShift1 = office1Work == office1;
            bool isShift2 = office2Work == office2;

            Console.WriteLine($"Режим работы первого офиса: {office1Work}");
            Console.WriteLine($"Режим работы второго офиса: {office2Work}");
            Console.ReadKey();


        }

    }
}
