using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ...
            Author: ...
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Madlibs is starting!");

            // Give the Mad Lib a title:
            string title = "Multiverse of Madlibs";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a color: ");
            string firstAdj = Console.ReadLine();
            Console.Write("Enter a feeling: ");
            string secondAdj = Console.ReadLine();
            Console.Write("Enter a texture: ");
            string thirdAdj = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string nounOne = Console.ReadLine();
            Console.Write("Enter another noun: ");
            string nounTwo = Console.ReadLine();

            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();




            // The template for the story:

            string story = $"This morning {name} woke up feeling {firstAdj}. 'It is going to be a {secondAdj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {thirdAdj}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. _{name}woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
