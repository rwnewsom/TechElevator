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

        // Methods
        string MakeSound();
    }
}
