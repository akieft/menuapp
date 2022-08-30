using System;

namespace Opdracht1MenuApp
{
    /// <summary>
    ///     Class Program is the startup for the application
    /// </summary>
    internal class Program
    {
        private static readonly Menu menu = new();

        /// <summary>
        ///     Main function
        /// </summary>
        private static void Main(string[] args)
        {
            // If the ShowMenu is returning true the menu is show again.
            while (true)
            {
                //Shows the menu.
                menu.ShowMenu();
                //Every time after showing the menu, the screen is cleared.
                Console.Clear();
            }
        }
    }
}