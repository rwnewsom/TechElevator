using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string filePath = Console.ReadLine();

            //2. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string targetWord = Console.ReadLine();
            //avoid erroneous input

            string caseSensitive = "";
            bool isYOrN = false;
            int lineNumber = 1;
            while (!isYOrN)
            {
                Console.WriteLine("Should the search be case sensitive? (Y\\N)");
                caseSensitive = Console.ReadLine().ToUpper();
                if (caseSensitive == "Y" || caseSensitive == "N")
                {
                    
                    isYOrN = true;
                }      
            }


            //3. Open the file - location follows for easy cut and paste - update to your file location!
            //  Your file path here ->     C:\Users\Student\source\robertnewsom-c-sharp-purple\module-1\16_FileIO_Reading_in\exercise-student\dotnet\alices_adventures_in_wonderland.txt
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    //4. Loop through each line in the file
                    string line = reader.ReadLine();
                    
                    if (caseSensitive == "Y")
                    {
                        //5. If the line contains the search string, print it out along with its line number
                        if (line.Contains(targetWord))
                        {
                            Console.WriteLine($"{lineNumber}) " + line);
                            lineNumber++;
                            continue;
                        }
                        lineNumber++;
                    }

                    else
                    {
                        if (line.Contains(targetWord, StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine($"{lineNumber}) " + line);
                            lineNumber++;
                            continue;
                        }
                        lineNumber++;
                    }          
                }
            }
        }
    }
}
