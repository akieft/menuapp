using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class MadLibs : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Mad Libs";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // Mad Lib title:
            var title = "===== A SHORT, MAD STORY =====";

            Console.WriteLine(
                "*** Note Add first your name in the menu before starting this story/ if you already did that you can start the story ***.");

            Console.WriteLine(title);
            // Define user input and variables:
            var name = SetName.Name;

            Console.Write("Enter an adjective: ");
            var adj1 = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            var adj2 = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            var adj3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            var verb = Console.ReadLine();

            Console.Write("Enter a noun: ");
            var noun1 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            var noun2 = Console.ReadLine();

            Console.Write("Enter An animal: ");
            var animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            var food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            var fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            var superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            var country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            var dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            var year = Console.ReadLine();

            // The template for the story:

            var story = $"This morning {name} woke up feeling {adj1}. " +
                        $"'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting " +
                        $"to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all " +
                        $"the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle " +
                        $"of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}