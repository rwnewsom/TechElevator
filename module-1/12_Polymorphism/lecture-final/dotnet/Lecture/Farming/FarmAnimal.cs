using System;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : System.Object, ISingable
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The farm animal's sound
        /// </summary>
        public string Sound { get; }

        public void BeginVerse()
        {
            Console.WriteLine("Let me tell you about the " + this.Name);
        }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name, string sound)
        {
            this.Name = name;
            this.Sound = sound;
        }

        public void Pet()
        {
            Console.WriteLine("You pet the " + this.Name);
        }
    }
}
