using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz Time!");

            //access the quiz file, need user input prompt or hard code 
            Console.WriteLine("Enter a complete file path to the quiz:");
            string filePath = Console.ReadLine();

            //initialize variables for totalQuestions and totalScore
            int totalQuestions = 0;
            int totalScore = 0;

            //catch bad file path or file
            //open the file and parse the lines


            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        //4. Loop through each line in the file
                        string line = reader.ReadLine();

                       /*                      
                            if (line.Contains(targetWord, StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.WriteLine($"{lineNumber}) " + line);
                                lineNumber++;
                                continue;
                            }
                            lineNumber++;
                       */ 
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file path: " + filePath + " was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Encounted an error working with " + filePath + ": " + ex.Message);
            }

            //split each line into a string array

            //loop through array to identify answer, assigning to an integer variable 

            //Display question and each answer, prefacing answers with index number, stripping asterisks


            //catch non int entry or entry out of range (1-4)
            //Prompt user to enter answer and compare with correct answer
            //increment totalQuestions
            //if correct answer, increment totalScore

            //continue loop until end of file

            //display final score by comparing total questions vs total correct answers
        }
    }
}
