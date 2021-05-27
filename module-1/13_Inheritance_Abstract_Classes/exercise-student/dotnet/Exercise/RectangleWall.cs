using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class RectangleWall : Wall
    {
        //PROPERTIES
        public int Length { get; }

        public int Height { get; }

        //CONSTRUCTORS

        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            this.Length = length;
            this.Height = height;
        }

        //METHODS

        public override int GetArea()
        {
            return this.Length*this.Height;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Length}x{this.Height}) rectangle";
        }


    }
}
