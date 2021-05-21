using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.GameExamples
{
    public class Player //put access modifier first!!
    {
        //PROPERTIES
        public string Name { get; }
        //delete set and it can only be set with the constructor
        public int Health { get; private set; }
        public int ExperiencePoints { get; private set; }

        //Derived Property
        //will never be set, read only
        public bool IsDead
        {
            get
            {
                if (this.Health <= 0)
                {
                    return true;
                }
                return false;
            }
        }

        //CONSTRUCTOR
        public Player(string name)
        {
            Console.WriteLine("Player Constructor Called");
            this.Health = 100;
            this.Name = name; // make sure the casing is correct here
        }
        
        //METHODS

        public int TakeDamage(int damageAmount)
        {
            /*
            this.Health -= damageAomunt;
            Console.WriteLine($"{this.Name} takes {damageAomunt} damage!");
            return this.Health; */
            return ModifyHealth(-damageAmount);
        }

        public int Heal(int amountToHeal)
        {
            /*this.Health += amountToHeal;
            Console.WriteLine($"{this.Name} has been healed for {amountToHeal}");
            return this.Health; */
            return ModifyHealth(amountToHeal);
        }

        private int ModifyHealth(int amountToChange)
            
        {
            this.Health += amountToChange;
            Console.WriteLine("Health is now "+this.Health);

            return this.Health;
        }

    }
}
