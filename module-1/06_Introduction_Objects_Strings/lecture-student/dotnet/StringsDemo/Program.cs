using System;

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

            char firstLetter = name[0];
            char secondLetter = name[name.Length-1];

            //Console.WriteLine("First and Last Character: ");
            Console.WriteLine("First and Last Character: " + firstLetter + secondLetter);


            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            string first3 = name.Substring(0, 3);
            Console.WriteLine("First 3 characters: " + first3);

            // 3. Now print out the last three characters
            // Output: ace

            string last3 = name.Substring(name.Length - 3, 3);
            Console.WriteLine("Last 3 characters: "+ last3);


            // 4. What about the last word?
            string[] firstAndLast = name.Split(' ');
            
            // Output: Lovelace


            Console.WriteLine("Last Word: " + firstAndLast[1]);


            // 5. Does the string contain inside of it "Love"?
            // Output: true
            bool hasLove = name.Contains("Love");


            Console.WriteLine("Contains \"Love\" " + hasLove);


            // 6. Where does the string "lace" show up in name?
            // Output: 8
            

            Console.WriteLine("Index of \"lace\": " + name.IndexOf("lace"));


            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int aCount = 0;
            foreach(char c in name)
            {
                if (c == 'a' || c=='A')
                {
                    aCount++;
                }
            }

            //alt code

            int numberOfAs = 0;
            for(int i=0; i<name.Length; i++)
            {
                string letter = name.Substring(i, 1);
                if (letter=="a" || letter=="b")
                {
                    numberOfAs++;
                }
            }
            


            Console.WriteLine("Number of \"a's\": " + aCount);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            string formalName = name.Replace("Ada", "Ada, Countess of Lovelace");
            Console.WriteLine(formalName);

            // 9. Set name equal to null.
            name = null;

            // 10. If name is equal to null or "", print out "All Done".
            if(name == null || name=="")
            {
                Console.WriteLine("All Done.");
            }
            Console.ReadLine();
        }
    }
}