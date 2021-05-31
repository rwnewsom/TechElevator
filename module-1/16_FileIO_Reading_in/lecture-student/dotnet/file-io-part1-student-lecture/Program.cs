using FileInputLecture.FileReading;
using System;
using System.IO;

namespace FileInputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXCEPTION HANDLING LECTURE CODE
            /*
            ExceptionLecture exLecture = new ExceptionLecture();
            exLecture.Part1Cities();
            exLecture.Part2OvertimeHours();
            exLecture.Part3CallStack();
            exLecture.Part4ThrowingExceptions();
            exLecture.Part5Finally();
            */

            // FILE READING LECTURE
            FileReadLecture fileLecture = new FileReadLecture();
            fileLecture.CensorAliceAndWonderland();

            // Allow the user to press a key
            Console.ReadLine();
        }

    }
}
