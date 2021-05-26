using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public sealed class Cat : FarmAnimal
    {
        public override double WeightInPounds { get; } = 9.0;

        public Cat() : base("Cat")
        {

        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }

    /* Cannot inherit from Cat because Cat is sealed
    public class SubCat : Cat
    {

    }
    */

}
