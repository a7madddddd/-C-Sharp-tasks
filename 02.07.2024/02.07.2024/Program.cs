using System;
namespace _02._07._2024
{
    public interface ISound{
        void MakeSound();
    }
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name){
            Name = name;
        }
        public abstract void Eat();
        public void Sleep(){
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
    public class Dog : Animal, ISound
    {
        public void MakeSound(){
            Console.WriteLine($"{Name} make this sound Woof!");
        }
        public Dog(string name) : base(name){}
        public override  void Eat(){
            Console.WriteLine($"is {Name} eating meal?");
        }
    }
    public class Cat : Animal , ISound
    {
        public void MakeSound(){
            Console.WriteLine($"{Name} is make this sound Meow!");
        }
        public override void Eat(){
            Console.WriteLine($"{Name} eating anything");
        }
        public Cat(string name) : base(name) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("bobo");
            Cat cat = new Cat("bebe");
            dog.MakeSound();
            dog.Sleep();
            dog.Eat();
            cat.Eat();
            cat.Sleep();
            cat.MakeSound();
        }
    }
}
