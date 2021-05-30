using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class UserInterface
    {
        public PetManager Pets { get; private set; }
        public Ledger Accounting { get; private set; }

        public UserInterface()
        {
            this.Pets = new PetManager();
            
        }

        public void ShowMainMenu()
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Please make a selection");
                Console.WriteLine("1 - Add Pet to Store");
                Console.WriteLine("2 - List Pets for Sale");
                Console.WriteLine("3 - Sell Pet to Customer");
                Console.WriteLine("4 - List Sales History");
                Console.WriteLine("Q - Exit");

                string userInput = Console.ReadLine();

                // TODO: Refactor these switch statements

                switch (userInput.ToLower())
                {
                    case "1": // Add Pet
                        Console.WriteLine("Please enter the Pet Type (Dog, Cat, Parrot, etc.)");
                        string petType = Console.ReadLine();

                        Console.WriteLine("What is this pet's name?");
                        string petName = Console.ReadLine();

                        Console.WriteLine("How much did we pay to acquire this pet?");
                        double purchasePrice = double.Parse(Console.ReadLine());

                        Console.WriteLine("How much is this pet on sale for?");
                        double salePrice = double.Parse(Console.ReadLine());

                        // TODO: Create an instance of a pet object
                        Pet newPet = new Pet();
                        newPet.PurchasePrice = purchasePrice;
                        newPet.SalePrice = salePrice;
                        newPet.Name = petName;
                        newPet.Type = petType;

                        // TODO: Add the pet to our store's inventory
                        Pets.NewPet(newPet);

                        // TODO: Add a transaction record to track the purchase

                        break;

                    case "2": // List Pets for Sale
                        int petNumber = 0;
                        //List<string> pets = new List<string>(); // TODO: Get this from a pet inventory manager
                        foreach (Pet pet in this.Pets.AvailablePets)
                        {
                            petNumber++;

                            double price = pet.SalePrice; // TODO: Get this from the specific pet
                            string noise = "TODO"; // TODO: Get this from the specific pet, preferably via a flimsy excuse for polymorphism

                            Console.WriteLine("Pet " + petNumber + ": " + pet + " makes noises like " + noise + " and has a sale price of " + price);
                        }

                        break;

                    case "3": // Sell Pet to Customer

                        SellPetToCustomer();

                        

                        break;

                    case "4": // List Sales History & Financial Info

                        // TODO: Loop over all sales history items and display them

                        // TODO: Sum the sale price of all animals currently in inventory as a total potential earnings

                        break;

                    case "q":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("Please a valid selection");
                        break;
                }

            }
        }

        private void SellPetToCustomer()
        {
            Console.WriteLine("Please select a pet to buy");
            int petNumber = 0;
            foreach (Pet petToBuy in this.Pets.AvailablePets)
            {
                petNumber++;
                Console.WriteLine(petNumber + ") " + petToBuy.ToString());
            }
            Console.WriteLine("Enter the name of the pet:");
            string petName = Console.ReadLine();
            //find the pet
            Pet pet = this.Pets.FindPetByName(petName);

            if (pet == null)
            {
                Console.WriteLine("There is no pet with that name");
            }

            else
            {
                this.Pets.Remove(pet);
            }

            

            // TODO: Determine which pet the customer is buying from us

            // TODO: Remove that pet from the store's inventory

            // TODO: Add a sale transaction
        }
    }
}
