using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class SquareWall : RectangleWall
    {
        //PROPERTIES

        public int SideLength { get; }

        //CONSTRUCTORS

        public SquareWall(string name, string color, int sideLength, int length, int height) : base(name, color, length, height)
        {
            this.SideLength = sideLength;
            
        }


        //METHODS

        public override int GetArea()
        {
            return SideLength * SideLength;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.SideLength}x{this.SideLength}) square";
        }




    }
}
