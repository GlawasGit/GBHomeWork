using System;
using System.IO;

namespace ConsoleApp7
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Salary { get; set; }
        public byte Age { get; set; }

        public Employee(string Name, string Position, string Email, string Phone, int Salary, int Age)
        {
            if (Age > 40)
            {
                Console.WriteLine($" ФИО: {Name}\n Должность: {Position}\n Email: {Email}\n Телефон: {Phone}\n Зарплата: {Salary}\n Возраст: {Age}\n");
            }
        }


       
        

    }
    class Program
    {

        static void Main(string[] args)
        {   
                Employee[] persArray = new Employee[5];
                persArray[0] = new Employee("Вячеслав Кобрин", "Генеральный директор", "vk@primer,ru", "+79996665544", 250000, 55);
                persArray[1] = new Employee("Иван Зайцев", "Директор по развитию", "vz@primer,ru", "+79998884455", 127000, 42);
                persArray[2] = new Employee("Дмитрий Медведев", "Охранник", "dm@primer,ru", "+79997771234", 19000, 21);
                persArray[3] = new Employee("Олеся Лисина", "Ведущий разработчик", "ol@primer,ru", "+79995554789", 120000, 28);
                persArray[4] = new Employee("Кристина Волкова", "Директор по работе с клиентами", "kv@primer,ru", "+79994445896", 138000, 48);


        }

        
    }
}
