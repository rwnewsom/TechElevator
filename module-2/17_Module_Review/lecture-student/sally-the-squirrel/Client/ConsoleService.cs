using SallyClient.Data;
using System;

namespace SallyClient
{
    public class ConsoleService
    {
        /// <summary>
        /// Prompts for a numeric return value
        /// </summary>
        /// <param name="action">String to print in prompt</param>
        /// <returns>ID</returns>
        public int PromptForNumber(string noun)
        {
            Console.WriteLine("");
            Console.Write($"Please enter {noun} (0 to cancel): ");

            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid input. Only input a number.");
                return 0;
            }

            return id;
        }

        public API_Question PromptForQuestion()
        {
            Console.WriteLine("What is your question's text?");
            string text = Console.ReadLine();

            Console.WriteLine("What is your question's answer?");
            string answer = Console.ReadLine();

            return new API_Question()
            {
                Text = text,
                Answer = answer,
            };
        }

        public LoginUser PromptForLogin()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            string password = GetPasswordFromConsole("Password: ");

            return new LoginUser
            {
                Username = username,
                Password = password
            };
        }

        private string GetPasswordFromConsole(string displayMessage)
        {
            string pass = "";
            Console.Write(displayMessage);
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // Backspace Should Not Work
                if (!char.IsControl(key.KeyChar))
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Remove(pass.Length - 1);
                        Console.Write("\b \b");
                    }
                }
            }

            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("");

            return pass;
        }
    }
}
