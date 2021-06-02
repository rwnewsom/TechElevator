using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{

    /// <summary>
    /// This class is responsible for displaying info to the user and getting input from the user, then handing off data to more specific processes
    /// </summary>
    public class UserInterface
    {
        public PetManager Pets { get; private set; } // = new PetManager();
        public Ledger Accounting { get; private set; }

        public UserInterface()
        {
            this.Pets = new PetManager();
            this.Accounting = new Ledger(this.Pets);
        }

        public void ShowMainMenu()
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                string userInput = GetUserMenuChoice();

                switch (userInput.ToLower())
                {
                    case "1": // Add Pet
                        AddNewPet();
                        break;

                    case "2": // List Pets for Sale
                        ListPets();
                        break;

                    case "3": // Sell Pet to Customer
                        SellPetToCustomer();
                        break;

                    case "4": // List Sales History & Financial Info
                        ListTransactionHistory();
                        break;

                    case "q":
                        keepGoing = false;
                        break;

                    default:
                        Console.WriteLine("Please make a valid selection");
                        break;
                }

            }
        }

        private string GetUserMenuChoice()
        {
            Console.WriteLine("Please make a selection");
            Console.WriteLine("1 - Add Pet to Store");
            Console.WriteLine("2 - List Pets for Sale");
            Console.WriteLine("3 - Sell Pet to Customer");
            Console.WriteLine("4 - List Sales History");
            Console.WriteLine("Q - Exit");
            Console.WriteLine();

            string userInput = Console.ReadLine();

            Console.WriteLine();

            return userInput;
        }

        private void ListPets()
        {
            int petNumber = 0;
            foreach (Pet pet in this.Pets.AvailablePets)
            {
                petNumber++;

                double price = pet.SalePrice; // Get this from the specific pet
                string noise = "TODO"; // TODO: Get this from the specific pet, preferably via a flimsy excuse for polymorphism

                Console.WriteLine("Pet " + petNumber + ": " + pet.ToString() + " makes noises like " + noise + " and has a sale price of " + price);
            }
        }

        private void AddNewPet()
        {
            Console.WriteLine("Please enter the Pet Type (Dog, Cat, Parrot, etc.)");
            string petType = Console.ReadLine();

            Console.WriteLine("What is this pet's name?");
            string petName = Console.ReadLine();

            Console.WriteLine("How much did we pay to acquire this pet?");
            double purchasePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("How much is this pet on sale for?");
            double salePrice = double.Parse(Console.ReadLine());

            // Create an instance of a pet object
            Pet newPet = new Pet();
            newPet.PurchasePrice = purchasePrice;
            newPet.SalePrice = salePrice;
            newPet.Name = petName;
            newPet.Type = petType;

            // Add the pet to our store's inventory
            Pets.NewPet(newPet);

            // TODO: Add a transaction record to track the purchase
            this.Accounting.NewPetAcquired(newPet);
        }

        private void ListTransactionHistory()
        {
            // Loop over all sales history items and display them
            string[] historyEntries = this.Accounting.SalesHistory;
            foreach (string entry in historyEntries)
            {
                Console.WriteLine(entry);
            }

            // Sum the sale price of all animals currently in inventory as a total potential earnings
            Console.WriteLine("Potential Earnings: " + this.Accounting.PotentialSalesOfAllPets);
        }

        private void SellPetToCustomer()
        {
            // Determine which pet the customer is buying from us
            Console.WriteLine("Please select a pet to buy");
            int petNumber = 0;
            foreach (Pet pet in this.Pets.AvailablePets)
            {
                petNumber++;
                Console.WriteLine(petNumber + ") " + pet.ToString());
            }

            Console.WriteLine("Enter the name of the pet");
            string petName = Console.ReadLine();

            // Find the pet
            Pet petToBuy = this.Pets.FindPetByName(petName);

            if (petToBuy == null)
            {
                Console.WriteLine("There is no pet with that name");
            } 
            else
            {
                Console.WriteLine("Sold for " + petToBuy.SalePrice);

                // Remove that pet from the store's inventory
                this.Pets.Remove(petToBuy);

                // TODO: Add a sale transaction
                this.Accounting.PetSold(petToBuy);
            }
        }
    }
}
