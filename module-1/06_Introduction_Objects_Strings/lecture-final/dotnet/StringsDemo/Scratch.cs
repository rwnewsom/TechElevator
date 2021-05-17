using System;
using System.Collections.Generic;
using System.Text;

namespace StringsDemo
{
    public class Scratch
    {

        public void SomeMethod()
        {
            // Value Types (Stack)

            int i = 100;
            int x = i; // i = 100, x = 100

            x = 50; // i = 100, x = 50

            // Reference Type (Heap)

            BankAccount myAccount = new BankAccount(500);
            BankAccount wifesAccount = myAccount;
            BankAccount johnsAccount = new BankAccount(10000);

            // Account has 500

            myAccount.Deposit(100); // Account has 600
            wifesAccount.Withdraw(600); // Account has 0

            // Pizza Example

            string[] myFavorites = { "Chicken Bacon Ranch", "Arugula", "Meat Lovers" };
            string[] brothersFavorites = myFavorites;
            string[] wifesFavorites = { "Cheese", "Hawaiian" };
            string[] momsFavorites = { "Cheese", "Hawaiian" };

            myFavorites[0] = "Glass Shards"; // {Glass Shards, Arugula, Meat Lovers}
            brothersFavorites[0] = "Veggies"; // {Veggies, Arugula, Meat Lovers}

            Console.WriteLine(wifesFavorites == momsFavorites); // False
            momsFavorites = wifesFavorites;
            Console.WriteLine(wifesFavorites == momsFavorites); // True

            // Strings

            string myName = "Matt Eland"; // new string("Matt Eland");
        }
    }
}
