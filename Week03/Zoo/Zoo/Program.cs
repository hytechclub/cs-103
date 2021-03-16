using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Animal> listOfAnimals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("Would you like to make a Reptile or a Mammal?");
                string animalType = Console.ReadLine();

                Console.WriteLine("What height is your animal?");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What weight is your animal?");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What age is your animal?");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What food does your animal eat?");
                string food = Console.ReadLine();

                Console.WriteLine("What is the name of your animal?");
                string name = Console.ReadLine();

                if (animalType.ToLower() == "reptile")
                {
                    Console.WriteLine("How many eggs does your reptile lay?");
                    int eggs = Convert.ToInt32(Console.ReadLine());

                    Reptile reptile = new Reptile(height, weight, age, food, name, eggs);
                    listOfAnimals.Add(reptile);
                }
                else if (animalType.ToLower() == "mammal")
                {
                    
                    Console.WriteLine("Does the animal have hair? yes/no");
                    string response = Console.ReadLine();
                    bool hasHair;
                    if (response.ToLower() == "yes")
                    {
                        hasHair = true;
                    }
                    else if (response.ToLower() == "no")
                    {
                        hasHair = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        hasHair = false;
                        Console.WriteLine("Setting animal hair to false");
                    }

                    Console.WriteLine("Do you want to make a Platypus? yes/no");
                    string platypusResponse = Console.ReadLine();
                    if (platypusResponse.ToLower() == "yes")
                    {
                        Platypus platypus = new Platypus(height, weight, age, food, name, hasHair);
                        listOfAnimals.Add(platypus);
                    }
                    else
                    {
                        Mammal mammal = new Mammal(height, weight, age, food, name, hasHair);
                        listOfAnimals.Add(mammal);
                    }
  
                }
                Console.WriteLine("If you would like to stop type stop.");
                if(Console.ReadLine().ToLower() == "stop")
                {
                    break;
                }
            }
            foreach(Animal animal in listOfAnimals)
            {
                Console.WriteLine(animal.Name);
                if(typeof(Reptile) == animal.GetType())
                {
                    Console.WriteLine(((Reptile)animal).Eggs);
                }
                if(animal is IWalk)
                {
                    ((IWalk)animal).Walk();
                }
            }
            Console.ReadLine();
        }
    }
}
