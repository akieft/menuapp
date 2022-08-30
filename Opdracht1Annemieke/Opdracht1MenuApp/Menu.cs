using System;
using Opdracht1MenuApp.MenuItems;
using static System.Console;

namespace Opdracht1MenuApp
{
    /// <summary>
    ///     The menu.
    /// </summary>
    internal class Menu
    {
        /// <summary>
        ///     The menu items.
        /// </summary>
        private readonly InterfaceMenu[] menuItems;

        public int _index;

        /// <summary>
        ///     Initializes a new instance of the menu class.
        /// </summary>
        public Menu()
        {
            // Initializes the menu items attribute.
            menuItems = new InterfaceMenu[]
            {
                //The menu item to add your name.
                new SetName(),

                //The menu item where you can see your name.
                new GetName(),

                //The menu item to make a + sum.
                new SumUp(),

                //The menu item to make a - sum.
                new Subtract(),

                //The menu item to make a * sum.
                new Divide(),

                //The menu item to make a / sum.
                new Multiply(),

                //The menu item to create a secret message.
                new Secret(),

                //The menu item to make Beep sound.
                new Beep(),

                //The menu item to go on adventure.
                new Adventure(),

                //The menu item to play MadLibs.
                new MadLibs(),

                // The Exit menu.
                new Exit()
            };
        }

        /// <summary>
        ///     Show the menu.
        /// </summary>
        public void ShowMenu()
        {
            CursorVisible = false;

            // 1. Shows the menu and add the name if the name is saved in SetName.
            WriteLine("*-*-*-*-*-*-*-*  Welcome {0} *-*-*-*-*-*-*-*", SetName.Name);

            for (var i = 0; i < menuItems.Length; i++)
            {
                if (i == _index)
                {
                    ForegroundColor = ConsoleColor.Magenta;


                    WriteLine("{0}: {1}",   (i + 1), menuItems[i].Title);
                }
                else
                {
                    WriteLine("{0}: {1}", (i + 1), menuItems[i].Title);
                }

                ResetColor();
            }

            var ckey = ReadKey();

            //If the user press down arrow key, the user can go to the the next menu item down.
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (_index == menuItems.Length - 1)
                {
                }
                else
                {
                    _index++;
                }
            }
            //If the user press up arrow key, the user can go to the the next menu item up.
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (_index <= 0)
                {
                }
                else
                {
                    _index--;
                }
            }
            //If the user press enter it can select the menu item he want to go.
            else if (ckey.Key == ConsoleKey.Enter)
            {
                if (_index < menuItems.Length)
                {
                    menuItems[_index].Execute();
                    ReadKey();
                }
            }
        }
    }
}