using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileInputLecture.FileReading
{
    public class FileReadLecture
    {
        public void CensorAliceAndWonderland()
        {
            // Let's take a look at DirectoryInfo and Environment
            string directoryPath = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            // Directory will look something like "C:\Users\Student\source\your-name-here\module-1\16_FileIO_Reading_in\student-lecture\dotnet\file-io-part1-student-lecture\bin\Debug\netcoreapp3.1"
            // We want to get the "dotnet" directory, so navigate up a few times
            while (directory.Name.ToLower() != "dotnet")
            {
                directory = directory.Parent;
            }

            // Let's take a look at Path
            string filename = "Alice.txt";
            string fullPath = Path.Combine(directory.FullName, filename);

            // Let's take a look at FileInfo
            FileInfo file = new FileInfo(fullPath);
            Console.WriteLine("Looking for file in " + fullPath + ": " + file.Exists);

            // Next we're going to demonstrate working with reading files
            DisplayCensoredFileContents(fullPath); // We also could have used file.FullName here

            Console.WriteLine();
        }

        private void DisplayCensoredFileContents(string filePath)
        {
            Console.WriteLine("Displaying the censored contents of " + filePath);

            // Feel free to tweak these to your enjoyment
            string wordToCensor = "Cat";
            string replacementWord = "Doggo";

            /* USING STATEMENTS
             * 
             * A using statement opens a resource and makes sure it is closed when
             * the scope completes - even if an Exception was encountered
             */

            // Add a using statement that creates a StreamReader pointing at the correct file
            {
                // While we haven't reached the end of the file...
                {
                    // Read in the next line from the file

                    // If the line needs censoring,
                    {
                        // Censor the line as needed by replacing WordToCensor with CensoredText

                        // Print the censored line to the Console
                    }
                }

            }


            Console.WriteLine("Done Censoring");

            // TODO: What happens if the file doesn't exist or we don't have permissions?

            // TODO: Can we handle generic exceptions and more specific exceptions in the same try / catch?
        }
    }
}
