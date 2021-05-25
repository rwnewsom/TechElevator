using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        // Things implementing ISingable MUST have these public members:

        // Properties
        string Name { get; }

        string Sound { get; }

        // string MusicalKey { get; }

        // Methods
        void BeginVerse();
    }

    // For reference:
    public class ISingableClassVersion
    {
        public string Name { get; }

        public string Sound { get; }

        public void BeginVerse()
        {
            Console.WriteLine("And now for something completely different");
        }
    }
}
