using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30._06._2024
{
    public class q5
    {
        public double Age; 
        public string Gender;
        public string Name;
        public string Email;
        public int ID;
        public int Phone;
        public q5(int age, string gender, string name, string email, int iD, int phone)
        {
            Age = age;
            Gender = gender;
            Name = name;
            Email = email;
            ID = iD;
            Phone = phone;
        }
    }
   


    internal class Program
    {
        static void myMethod()
        {
            double age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((age * 365) + "in days");

        }
        static void Main(string[] args)
        {
            //q1
            Console.WriteLine("task-1");
            Console.WriteLine("enter a number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter more numbers");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double number4 = Convert.ToDouble(Console.ReadLine());
            double number5 = Convert.ToDouble(Console.ReadLine());
            double number6 = Convert.ToDouble(Console.ReadLine());
            double number7 = Convert.ToDouble(Console.ReadLine());
            double number8 = Convert.ToDouble(Console.ReadLine());
            double number9 = Convert.ToDouble(Console.ReadLine());
            double number10 = Convert.ToDouble(Console.ReadLine());
            double total = (number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9 + number10);
            Console.WriteLine(total);
            double Average = (number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9 + number10) / 3;
            Console.WriteLine(Average);
            Console.WriteLine("......................................................");



            //q2
            Console.WriteLine("task-2");
            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (i == num1)
                {
                    Console.WriteLine(num1);
                    Console.WriteLine(i * i * i);
                }
                else if (i == num2)
                {
                    Console.WriteLine(num2);
                    Console.WriteLine(i * i * i);

                }
                else if (i == num3)
                {
                    Console.WriteLine(num3);
                    Console.WriteLine(i * i * i);

                };

            }
            Console.WriteLine("................");

            Console.WriteLine("Task - 3");

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            foreach (double year in years)
            {
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            };
            Console.WriteLine("........................");

            //q4

            Console.WriteLine("enter a year");
            myMethod();
            Console.WriteLine("....................");


            //q5
            Console.WriteLine("task-5");
            q5 information = new q5(20, "male", "Ali", "info@gmail.com", 200088866, 0770000000);
            Console.WriteLine(information.Age + " " + information.Gender + " " + information.Name + " " + information.Email + " " + information.ID + " " + information.Phone);
            Console.WriteLine(".......................");



        }
    }
}
