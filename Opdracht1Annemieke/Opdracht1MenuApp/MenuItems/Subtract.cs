using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class Subtract : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Subtract";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // Information for the user.
            Console.WriteLine("We are going make a som ");
            Console.WriteLine("Write the first number and press enter");

            int num1, num2;

            //First input for user.
            while (true)
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Please write a number.");
                }

            //  Information for the user.
            Console.WriteLine("Write the second number and press enter.");

            //Second input for user.
            while (true)
                try
                {
                    num2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Please write a number.");
                }

            //Sum and the answer
            Console.WriteLine($"Your sum is: {num1} - {num2} = {num1 - num2}");
        }
    }
}