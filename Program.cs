using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var Animal1 = new Animal();
            Animal1.name = "Maggie";

            Console.WriteLine(Animal1.name);
            
            Animal.sleep();

            var Bandit = new Cat();
            Bandit.name = "Bandit";
            Bandit.cuteness = "goddamn adorable";
            Cat.sleep();

            Console.WriteLine($"I have a cat named {Bandit.name} who makes a noise that sounds like {Bandit.noise}. I'd rate its cuteness at {Bandit.cuteness}.");
            Console.WriteLine();
        }
    }
}
