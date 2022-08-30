using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class Adventure : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Adventure";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // Intro adventure game
            Console.WriteLine("===== THE MYSTERIOUS NOISE =====");
            Console.WriteLine("Do you dare to go on adventure {0}?", SetName.Name);

            Console.WriteLine("WELCOME TO OUR STORY");

            Console.WriteLine(
                "It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            //First option
            Console.Write("Type YES or NO:");
            var noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();

            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
            }

            //Second option
            Console.Write("Type OPEN or KNOCK: ");
            var doorChoice = Console.ReadLine();
            doorChoice = doorChoice.ToUpper();

            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says,\"Answer this riddle: \"");
                Console.WriteLine("Poor people have it. Rich people need it. If you eat it you die. What is it?");

                //Answer option
                Console.Write("Type your answer: ");
                var riddleAnswer = Console.ReadLine();
                riddleAnswer = riddleAnswer.ToUpper();

                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there.");
                    Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                    Console.WriteLine("THE END");
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.");
                }
            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3): ");
                var keyChoice = Console.ReadLine();
                keyChoice = keyChoice.ToUpper();

                // Key options
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice!");
                        Console.WriteLine("The door opens and NOTHING is there. Strange...");
                        Console.WriteLine("THE END");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key.");
                        Console.WriteLine("The door doesn't open.");
                        Console.WriteLine("THE END");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key");
                        Console.WriteLine("The door doesn't open");
                        Console.WriteLine("THE END");
                        break;
                }
            }
        }
    }
}