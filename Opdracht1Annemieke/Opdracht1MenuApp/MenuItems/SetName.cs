using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class SetName : InterfaceMenu
    {
        public static string Name { get; private set; }

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Add your name";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // Save the user name
            Console.WriteLine("Enter your name: .");
            Name = Console.ReadLine();
            Console.WriteLine("Your name is saved.");
        }
    }
}