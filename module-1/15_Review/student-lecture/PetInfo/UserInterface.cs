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

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Please enter the Pet Type (Dog, Cat, Parrot, etc.)");
                        string petType = Console.ReadLine();

                        Console.WriteLine("What is this pet's name?");
                        string petName = Console.ReadLine();

                        Console.WriteLine("How much did we pay to acquire this pet?");
                        double purchasePrice = double.Parse(Console.ReadLine());

                        Console.WriteLine("How much is this pet on sale for?");
                        double salePrice = double.Parse(Console.ReadLine());

                        // TODO: Create a pet instance

                        // TODO: Add the pet to our store's inventory

                        // TODO: Add a transaction record to track the purchase

                        break;
                    case "2":
                        int petNumber = 0;
                        List<string> pets = new List<string>();
                        foreach (string pet in pets)
                        {
                            petNumber++;
                            Console.WriteLine("Pet " + petNumber + ": " + pet + " makes noises like [TODO] and has a sale price of [TODO]");
                        }

                        break;

                    case "3":
                        // TODO: Determine which pet they'd like to sell

                        // TODO: Remove that pet from the store's inventory

                        // TODO: Add a sale transaction

                        break;

                    case "4":
                        // TODO: Loop over all sales history items and display them

                        // TODO: Sum the sale price of all animals currently in inventory as a total potential earnings

                        break;

                    case "Q":
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
