using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07._2024
{
    //task-1& 2
    public class Car
    {
        private bool engin;

        public string Make { set; get; }
        public int Year { set; get; }
        public string Type { set; get; }
        public int Price { set; get; }
        public string Model { set; get; }
        public string PalletNo { set; get; }
        public string Color { set; get; }

        public Car(string make, int year, string type, int price, string model, string palletNo, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
            engin = false;
        }
        public void carInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"PalletNo: {PalletNo}");
            Console.WriteLine($"Color: {Color}");

        }
        public override string ToString()
        {
            string engineStatus = engin ? "Running" : "Stopped";
            return $"Car Info:\n" +
                   $"- Make: {Make}\n" +
                   $"- Year: {Year}\n" +
                   $"- Type: {Type}\n" +
                   $"- Price: {Price:C}\n" +
                   $"- Model: {Model}\n" +
                   $"- Pallet No: {PalletNo}\n" +
                   $"- Color: {Color}\n" +
                   $"- Engine Status: {engineStatus}";
        }
        public void StartEngine()
        {
            if (engin)
            {
                Console.WriteLine("engine is running");
            }
            else
            {
                engin = true;
                Console.WriteLine("engine has started");
            }
        }
        public void StopEngine()
        {
            if (engin)
            {
                engin = false;
                Console.WriteLine("engine has stopped.");
            }
            else
            {
                Console.WriteLine("engine is already stopped.");
            }
        }

    }

    public class BMW : Car 
    {

        public BMW(string make, int year, string type, int price, string model, string palletNo, string color)
            : base(make, year, type, price, model, palletNo, color);

    };
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1& 2
            Console.WriteLine("task1&2");
            Car car = new Car("Mercedes", 2022, "Cls", 40000, "Cls-63", "189849", "Mat Black");
            car.carInfo();
            Console.WriteLine("........................");
            //Task-3
            Console.WriteLine("task-3");
            car.StartEngine(); 
            
            car.StartEngine();

            car.StopEngine(); 
            
            car.StopEngine(); 

            Console.WriteLine("......................");
            
        }
      }
    }

