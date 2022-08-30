using System;

namespace Opdracht1MenuApp.MenuItems
{
    internal class Secret : InterfaceMenu
    {
        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Title" />
        /// </summary>
        public string Title => "Create secret message";

        /// <summary>
        ///     <inheritdoc cref="InterfaceMenu.Execute" />
        /// </summary>
        public void Execute()
        {
            // The letters the user can only use for there secret message.
            char[] alphabet =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };

            // Introduction and guideline how to use this program for the user.
            Console.WriteLine("Welcome to your secret message program.");
            Console.WriteLine(
                "In this program you can only use lowercase letters. NO: numbers, uppercase letters or symbols.");
            Console.WriteLine("Enter your secret message: ");

            //Input user message.
            var input = Console.ReadLine();
            var yourMessage = input.ToCharArray();

            //Change the input from user to a secret message
            var secretMessage = new char[yourMessage.Length];

            for (var i = 0; i < yourMessage.Length; i++)
            {
                var letter = yourMessage[i];
                var letterPosition = Array.IndexOf(alphabet, letter);
                var newLetterPosition = (letterPosition + 3) % 26;
                var letterEncoded = alphabet[newLetterPosition];
                secretMessage[i] = letterEncoded;
            }

            //Show the user secret message.
            var encodedString = string.Join("", secretMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}");
        }
    }
}