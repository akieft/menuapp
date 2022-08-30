using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class Beep : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Beep";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            //Instruction for user
            Console.WriteLine("Make some sounds you can do that by using the next keys: A, S, D, F, G, H, J");

            //C, C#, D, Eb, E, F, F#, G, G#, A, Bb, B
            int[] fq = {261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493};

            var duration = 250;

            //Switch case with the key the user press and the frequentie and duration from the beep.
            while (true)
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(fq[7], duration);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(fq[9], duration);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(fq[11], duration);
                        break;
                    case ConsoleKey.F:
                        Console.Beep(fq[0], duration);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(fq[2], duration);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(fq[4], duration);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(fq[5], duration);
                        break;
                    default:
                        return;
                }
        }
    }
}