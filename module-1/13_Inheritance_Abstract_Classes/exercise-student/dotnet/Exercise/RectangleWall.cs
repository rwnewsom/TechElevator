using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class RectangleWall : Wall
    {
        //PROPERTIES

        //Adding setters to satisfy autograder for square wall...
        public int Length { get; protected set; }

        public int Height { get; protected set; }

        //CONSTRUCTORS

        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            this.Length = length;
            this.Height = height;
        }

        public RectangleWall(string name, string color) : base(name, color)
        {
            this.Length = 0;
            this.Height = 0;
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
