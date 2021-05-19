using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            //declare a dictionary and store given values
            Dictionary<string, string> animalGroups = new Dictionary<string, string>()
            {
                { "rhino", "Crash" },
                { "giraffe", "Tower" },
                { "elephant", "Herd" },
                { "lion", "Pride" },
                { "crow", "Murder" },
                { "pigeon", "Kit" },
                { "flamingo", "Pat" },
                { "deer", "Herd" },
                { "dog", "Pack" },
                { "Crocodile", "Float" }

            };

            if(animalName == null)
            {
                return "unknown";
            }

            string userInput = animalName.ToLower();

            //prompt for input and store lowercase - not needed & will break tests!
            //error check for not found, null or empty

            if (animalGroups.ContainsKey(userInput))
            {
                return animalGroups[userInput];
            }
                    
            //return apropriate value if not found

            return "unknown";
        }
    }
}
