using System;

namespace task_26_64
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //q1
            int x = 7;
            int y = 6;

            if (x > y)
            {
                Console.WriteLine("7 greater than 6");
            }
            else
            {
                Console.WriteLine("6 greater than 7");
            }

            Console.WriteLine("enter another number");
            //q2
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);
            if (a > 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (a < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else
            {
                Console.WriteLine("The sign is 0");
            };

            //q3
            Console.WriteLine("sorting array of number: ");

            int[] arr1 = new int[] { 0, -1, 4 };
            Array.Sort(arr1);
            foreach (int i in arr1) { Console.WriteLine(i); }




            //q4
            //-5, -2, -6, 0, -1 
            if (-5 > -2 && -5 > -6 && -5 > 0 && -5 > -1)
            {
                Console.WriteLine("-5 is greater than all number");
            }
            else if (-2 > -5 && -2 > -6 && -2 > 0 && -2 > -1)
            {
                Console.WriteLine("-2 is greater than all number");
            }
            else if (-6 > -5 && -6 > -2 && -6 > 0 && -6 > -1)
            {
                Console.WriteLine("-6 is greater than all number");

            }
            else if (0 > -5 && 0 > -2 && 0 > -6 && 0 > -1)
            {
                Console.WriteLine("0 is greater than all number");

            }
            else
            {
                Console.WriteLine("0 is greater than all number");
            }


            //q5

            Console.WriteLine("add kilometers");
            string entered = Console.ReadLine();

            double kilometers;
            bool Space = double.TryParse(entered, out kilometers);
            if (Space)
            {
                double milesInHour = kilometers * 0.621371;
                Console.WriteLine("{0} kilometers per hour is equal to {1} miles per hour.", kilometers, milesInHour);
            }


            //q6

            Console.WriteLine("enter an hours ");
            string enterd = Console.ReadLine();
            Console.WriteLine("enter an minuts");
            string enterd2 = Console.ReadLine();

            int hours;
            int minutes;
            bool hourstominuts = int.TryParse(enterd, out hours);
            bool minutstohours = int.TryParse(enterd2, out minutes);
            if (hourstominuts && minutstohours)
            {
                int finalTime = (hours * 60) + minutes;
                Console.WriteLine("{0} minuts", finalTime);
            }



            //q7

            Console.WriteLine("enter minutes");
            string m1 = Console.ReadLine();


            int m2;
            bool minutsToHours = int.TryParse(m1, out m2);
            if (minutsToHours)
            {
                int hour = m2 / 60;
                int min = m2 % 60;
                Console.WriteLine("{0} hour, {1}imnutes ", hour, min);
            }



            //q8

            string[] different = { "ahmad", "onizat", "love sleep", "love coffee so much", "and this is good" };
            Console.WriteLine(different[0].Substring(0, 5));
            Console.WriteLine(different[1].Substring(0, 5));
            Console.WriteLine(different[2].Substring(0, 5));
            Console.WriteLine(different[3].Substring(0, 5));
            Console.WriteLine(different[4].Substring(0, 5));





        }
    }
}
