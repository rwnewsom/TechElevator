using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public abstract class FlyingFarmAnimal : FarmAnimal
    {
        // TODO: We need a max altitude in meters property

        public override double WeightInPounds { get; } = 0.0;

        public FlyingFarmAnimal(string name) : base(name)
        {
        }

        public virtual void Fly()
        {
            Console.WriteLine("Generic flying implementation");
        }

        // TODO: We need a land method!
    }
}
