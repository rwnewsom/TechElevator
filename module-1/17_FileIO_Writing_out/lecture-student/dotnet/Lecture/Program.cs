using System;
using System.IO;
using Lecture.Aids;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1 - Writing to a File
            string path = @"C:\Users\Student\FileIOLecture.txt";

            //plug in a catch for IO exceptions (locked, no space etc)

            try
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine("Rainy Wednesdays");
                    writer.WriteLine(DateTime.UtcNow);
                }

            }

            catch(IOException ex)
            {
                Console.WriteLine("Could not write to " + path +": " + ex.Message);
            }



            // PART 2 - Reading and Writing

            string directory = Environment.CurrentDirectory;
            string hamletPath = Path.Combine(directory, "hamlet.txt");
            string output = @"C:\Users\Student\hamlet2.txt";
            using (StreamReader reader = new StreamReader(hamletPath))
            {
                using (StreamWriter writer = new StreamWriter(output, false))
                {
                    while (!reader.EndOfStream)
                    {
                        // Loop through the contents of Hamlet and display each line on the screen
                        string line = reader.ReadLine();
                        //Console.WriteLine(line);

                        line = line.Replace("FRANCISCO", "FRANKY");
                        writer.WriteLine(line);
                    }

                }
                
                

            }



            // Write out the modified contents of Hamlet to a separate file Francisco to Franky

            // PART 3 - Other Examples

            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
