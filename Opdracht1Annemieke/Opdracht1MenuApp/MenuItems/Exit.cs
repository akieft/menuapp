using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class Exit : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Goodbye";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // Stops the program.
            Environment.Exit(0);
        }
    }
}