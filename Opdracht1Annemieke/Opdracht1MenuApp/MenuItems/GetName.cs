using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class GetName : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Show your name";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // Show the name after saved in SetName menu item.
            Console.WriteLine("Hello {0} how are you, How is life on Jupiter?", SetName.Name);
        }
    }
}