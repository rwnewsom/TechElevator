using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			// ----------------------------------------
			// Dictionaries
			// ----------------------------------------

			// Declaring and initializing a Dictionary <TKey, TValue>

			Dictionary<string, int> numberOfPurchases = new Dictionary<string, int>();
			Dictionary<int, string> jerseyAssignments = new Dictionary<int, string>();

			// Adding an item to a Dictionary
			numberOfPurchases["Frodo"] = 1;
			numberOfPurchases["JFulton"] = 48;
			numberOfPurchases["Wes"] = 1;
            numberOfPurchases["AbeLincoln"] = 8;

			jerseyAssignments[99] = "Wayne Gretzky";
			jerseyAssignments[23] = "Michael Jordan";
			jerseyAssignments[42] = "Matt Eland";

            // Retrieving an item from a Dictionary by its key
            string ownerOfJersey42 = jerseyAssignments[42];
            // can't do this! exception ... int abesPurchases = numberOfPurchases["AbeLincoln"];
			// Updating an item in a Dictionary
			jerseyAssignments[42] = "Bobby Orr"; //will update the value of the existing key

            // Check to see if a key already exists
            int abesPurchases = 0;
            if (numberOfPurchases.ContainsKey("AbeLincoln"))
            {
                abesPurchases = numberOfPurchases["AbeLincoln"];
            }

            // Remove an element from the Dictionary
            jerseyAssignments.Remove(42);
            numberOfPurchases.Remove("Wes");
            numberOfPurchases.Remove("ThisKeyDoesNotExist"); //ignored

            // ----------------------------------------
            // Less Common Cases with Dictionaries
            // ----------------------------------------

            // Declaring and initializing a Dictionary (one-line version)
            Dictionary<string, string> badSecurityPractice = new Dictionary<string, string>()
            {
                { "meland", "password" },
                {"heland", "password" },
                {"wes", "swordfish" }
            };

            // Iterate through the key-value pairs in the Dictionary (You will RARELY do this)
            //never store password etc in a dictionary
            foreach(KeyValuePair<string, string> pair in badSecurityPractice)
            {
                Console.WriteLine(pair.Key + " has a password of " + pair.Value);
            }  //could compare without looping eg badSecurityPractice["meland"== "inputPassword"]
            
            Console.WriteLine("Please enter a user name:");
            string userName = Console.ReadLine();
            userName = userName.ToLower();
            Console.WriteLine("Please enter your password");
            string userPassword = Console.ReadLine();

            if (badSecurityPractice.ContainsKey(userName))
            {
                if (badSecurityPractice[userName] == userPassword)
                {
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }

            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            

            // Retrieving just the keys from a Dictionary (You will RARELY do this)
            Console.WriteLine("Current Users of the System:");
            foreach (string key in badSecurityPractice.Keys)
            {
                Console.WriteLine(key);
            }

            // Null Reference Exceptions
            string externalUsername = null; //only works with reference types
            if (externalUsername != null)
            {
                externalUsername = externalUsername.ToLower();
            }


            // Case Sensitivity in Keys

            // ----------------------------------------
            // HashSets
            // ----------------------------------------

            // Declaring a hash set

            HashSet<string> emailAddresses = new HashSet<string>();

            // Adding to hash sets
            emailAddresses.Add("matt.eland@techelevator.com");
            emailAddresses.Add("john@techelevator.com");
            emailAddresses.Add("vinny@techelevator.com");
            emailAddresses.Add("matt.eland@techelevator.com");
            emailAddresses.Add("Vinny@techelevator.com"); //case sensitive, best to convert to lower before storing

            // Removing from hash sets

            // Checking if something is in a hash set

            // Looping over a hash set
            foreach(string email in emailAddresses)
            {
                Console.WriteLine("Now spamming: " + email);
            }


            Console.WriteLine("hello world");
		}
	}
}
