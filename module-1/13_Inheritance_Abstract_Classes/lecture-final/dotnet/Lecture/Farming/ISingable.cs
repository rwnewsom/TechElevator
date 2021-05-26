using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        // private string albumName;

        // Things implementing ISingable MUST have these public members:

        // Properties
        string Name { get; }

        // Methods
        string MakeSound();
    }
}
