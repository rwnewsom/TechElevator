using System;

namespace PetInfo
{
    class Program
    {
        //In class exercise

        //Provide a menu of choices for the user to choose functionality
        //Allow user to choose to enter data any one type of pets(dogs, cats, parrots)
        //Allow user to choose how many pets they want to enter
        //Ask user to enter pet name for each pet
        //Allow user to show names of pets

        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            ui.ShowMainMenu();
        }


    }
}


