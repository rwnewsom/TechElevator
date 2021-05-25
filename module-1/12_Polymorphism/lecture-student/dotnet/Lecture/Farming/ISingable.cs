using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        //public by default
        //Things implementing ISingable MUST have these public members:


        //PROPERTIES
        string Name { get; }
        string Sound { get; }

        //string MusicalKey { get;  } demonstrates enforcement by compiler


        //METHODS
        void BeginVerse();
        //note no method body {}
        //Hence use ;
    }




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
