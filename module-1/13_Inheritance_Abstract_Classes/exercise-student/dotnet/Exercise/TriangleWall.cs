using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class TriangleWall : Wall
    {
        //PROPERTIES
        public int Base { get; }
        public int Height { get; }


        //CONSTRUCTORS

        public TriangleWall(string name, string color, int @base, int height) : base(name, color)
        {
            Base = @base;
            Height = height;
        }

        //METHODS

        public override int GetArea()
        {
            return (this.Base * this.Height)/2;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Base}x{this.Height}) triangle";
        }

    }
}
