﻿using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character: ");
            Console.WriteLine(name[0]);
            Console.WriteLine(name[name.Length - 1]);


            // 2. How do we write code that prints out the first three characters
            // Output: Ada


            Console.WriteLine("First 3 characters: ");

            string first3 = name.Substring(0, 3);
            Console.WriteLine(first3);

            // 3. Now print out the last three characters
            // Output: ace

            Console.WriteLine("Last 3 characters: ");

            string last3 = name.Substring(name.Length - 3, 3); // Also works: .Substring(name.Length - 3)
            Console.WriteLine(last3);

            // 4. What about the last word?
            // Output: Lovelace


            Console.WriteLine("Last Word: ");
            // "Ada Lovelace" -> { "Ada", "Lovelace"}
            string[] words = name.Split(" ");
            Console.WriteLine(words[words.Length - 1]); // words[1] works too

            Console.WriteLine(name.Substring(4));

            // Don't Do this
            name.ToUpper();
            Console.WriteLine(name);

            // Instead do this
            Console.WriteLine(name.ToUpper());

            // 5. Does the string contain inside of it "Love"?
            // Output: true


            Console.WriteLine("Contains \"Love\"");
            Console.WriteLine(name.Contains("Love"));
            Console.WriteLine(name.Contains("love"));


            // 6. Where does the string "lace" show up in name?
            // Output: 8


            Console.WriteLine("Index of \"lace\": ");
            Console.WriteLine(name.IndexOf("lace"));
            Console.WriteLine(name.IndexOf("Batman")); // When it isn't found, index is returned as -1


            // 7. How many 'a's OR 'A's are in name?
            // Output: 3


            Console.WriteLine("Number of \"a's\": ");
            int numberOfAs = 0;
            for (int i = 0; i < name.Length; i++)
            {
                string letter = name.Substring(i, 1); // name[i] returns a char

                //if (letter == "a" || letter == "A")
                if (letter.ToLower() == "a")
                {
                    numberOfAs++; // numberOfAs = numberOfAs + 1
                }
            }
            Console.WriteLine(numberOfAs);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            name = name.Replace("Ada", "Ada, Countess of Lovelace"); // "Ada Lovelace" -> "Ada, Countess of Lovelace Lovelace"
            Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;
            Console.WriteLine(name);

            // 10. If name is equal to null or "", print out "All Done".
            //if (name == null || name == "")
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done");
            }

            Console.ReadLine();
        }
    }
}