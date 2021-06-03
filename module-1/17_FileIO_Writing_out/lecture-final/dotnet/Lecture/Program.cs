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

            try
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine("Rainy Wednesdays");
                    writer.WriteLine("Are full of energy");
                    writer.WriteLine("But not enough caffeine");

                    writer.WriteLine("My favorite number is " + 42);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Could not write to " + path + ": " + ex.Message);
            }

            // PART 2 - Reading and Writing

            string directory = Environment.CurrentDirectory;
            string hamletPath = Path.Combine(directory, "hamlet.txt");
            string output = @"C:\users\student\Hamlet2.txt";

            using (StreamReader reader = new StreamReader(hamletPath))
            {
                using (StreamWriter writer = new StreamWriter(output, false))
                {
                    while (!reader.EndOfStream)
                    {
                        // Loop through the contents of Hamlet and display each line on the screen
                        string line = reader.ReadLine();

                        // Console.WriteLine(line);
                        // Rename FRANSISCO to FRANKY
                        line = line.Replace("FRANCISCO", "FRANKY");

                        writer.WriteLine(line);

                        // writer.Flush();
                    }

                }
            }

            // Write out the modified contents of Hamlet to a separate file. We'll rename FRANCISCO to FRANKY

            // PART 3 - Other Examples

            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
