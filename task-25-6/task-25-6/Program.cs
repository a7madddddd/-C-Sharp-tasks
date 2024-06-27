using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_25_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            Console.WriteLine("enter your name");
            string x = Console.ReadLine();
            Console.WriteLine(x);





            // task 2

            double double1 = 1.1;
            string string1 = "ahmad";
            char char1 = 'A';
            bool bool1 = false;
            int int1 = 1;
            const string string2 = "i love sleep";

            Console.WriteLine("double1 " + double1);
            Console.WriteLine("string1 " + string1);
            Console.WriteLine("char1 " + char1);
            Console.WriteLine("bool1 " + bool1);
            Console.WriteLine("int1 " + int1);
            Console.WriteLine("string2 " + string2);


            // task 3

            string[] cars;
            cars = new string[] { "mercedes", "lambo", "volkswagn", "gmc" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            };
            Console.WriteLine(cars.Length);



            // task 4

            string firstName;
            string surName;
            int birthYear;
            Console.WriteLine("input your first name ");
            firstName = Console.ReadLine();

            Console.WriteLine("input your surname ");
            surName = Console.ReadLine();

            Console.WriteLine("input your birth year");
            birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine(firstName + " " + surName + " " + birthYear);



            // task 5
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Input element - {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
