using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class UserInterface
    {
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

                        // TODO: Add the pet to our store's inventory

                        // TODO: Add a transaction record to track the purchase

                        break;

                    case "2": // List Pets for Sale
                        int petNumber = 0;
                        List<string> pets = new List<string>(); // TODO: Get this from a pet inventory manager
                        foreach (string pet in pets)
                        {
                            petNumber++;

                            double price = 0.0; // TODO: Get this from the specific pet
                            string noise = "TODO"; // TODO: Get this from the specific pet, preferably via a flimsy excuse for polymorphism

                            Console.WriteLine("Pet " + petNumber + ": " + pet + " makes noises like " + noise + " and has a sale price of " + price);
                        }

                        break;

                    case "3": // Sell Pet to Customer

                        // TODO: Determine which pet the customer is buying from us

                        // TODO: Remove that pet from the store's inventory

                        // TODO: Add a sale transaction

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
    }
}
