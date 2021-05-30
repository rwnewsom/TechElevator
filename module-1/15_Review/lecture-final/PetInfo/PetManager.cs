using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class PetManager
    {
        private List<Pet> pets = new List<Pet>();

        /*
        public PetManager(List<Pet> pets)
        {
            this.pets = pets;
        }
        */

        public void NewPet(Pet petToAdd)
        {
            this.pets.Add(petToAdd);
        }

        public Pet[] AvailablePets
        {
            get
            {
                // Using ToArray()
                return this.pets.ToArray();
            }
        }

        public Pet FindPetByName(string name)
        {
            foreach (Pet pet in this.pets)
            {
                if (pet.Name == name)
                {
                    return pet;
                }
            }

            return null;
        }

        public void Remove(Pet pet)
        {            
            this.pets.Remove(pet);
        }
    }
}
