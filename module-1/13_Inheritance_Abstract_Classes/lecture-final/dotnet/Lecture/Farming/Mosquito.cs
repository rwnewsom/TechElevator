using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Mosquito : FlyingFarmAnimal
    {
        public Mosquito() : base("Mosquito")
        {

        }

        public override string MakeSound()
        {
            return "Bzzzzzzz";
        }
    }
}
