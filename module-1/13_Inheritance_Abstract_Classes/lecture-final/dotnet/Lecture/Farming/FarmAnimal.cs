using System;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {
        private string animalBreed;

        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        protected FarmAnimal(string name)
        {
            this.Name = name;
            this.animalBreed = "Moose";
        }

        public abstract double WeightInPounds { get; }

        /// <summary>
        /// Gets the sound the animal should make
        /// </summary>
        /// <returns>The sound the animal should make</returns>
        public abstract string MakeSound();

        public virtual void Pet()
        {
            Console.WriteLine("You pet the " + this.Name);
        }

    }
}
