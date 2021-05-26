using System;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : ISingable
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the sound the animal should make
        /// </summary>
        /// <returns>The sound the animal should make</returns>
        public virtual string MakeSound()
        {
            return "Nobody should see this; each animal should override this method!";
        }

        public void Pet()
        {
            Console.WriteLine("You pet the " + this.Name);
        }

    }
}
