using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public abstract class Wall
    {
        //PROPERTIES
        public string Name { get; }

        public string Color { get; }

        //CONSTRUCTORS

        public Wall(string name, string color)
        {
            
            this.Color = color;
            this.Name = name;
        }

        //METHODS

        /// <summary>
        /// If you see this - override the method!
        /// </summary>
        /// <returns></returns>
        public virtual int GetArea()
        {
            //inheriting classes should override
            return 0;
        }
        
        
    }
}
