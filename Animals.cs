using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }

        public string cuteness {get; set;}

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }
    class Dog : Animal
    {
        public string noise = "bark";
    }
    class Cat : Animal
    {
        public string noise = "meow";
    }
    class Bird : Animal
    {
        public string noise = "squak";
    }
}