using System;
using System.Collections.Generic;
//using System.Collections.Generic;

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
			// Can't do this: numberOfPurchases["Rachelle"] = "Puppy";
			// Can't do this: numberOfPurchases[4] = 4;

			jerseyAssignments[99] = "Wayne Gretzky";
			jerseyAssignments[23] = "Michael Jordan";
			jerseyAssignments[42] = "Matt Eland";

			// Retrieving an item from a Dictionary by its key
			string ownerOfJersey42 = jerseyAssignments[42];
			// Can't do this, key isn't present: int abesPurchases = numberOfPurchases["AbeLincoln"];

			// Updating an item in a Dictionary
			jerseyAssignments[42] = "Bobby Orr"; // Will update the value of the existing key

			// Check to see if a key already exists
			int abesPurchases = 0;
			if (numberOfPurchases.ContainsKey("AbeLincoln"))
            {
				abesPurchases = numberOfPurchases["AbeLincoln"];
            }

			// Remove an element from the Dictionary
			jerseyAssignments.Remove(42);
			numberOfPurchases.Remove("Wes");
			numberOfPurchases.Remove("ThisKeyDoesNotExistInTheDictionary");

			// ----------------------------------------
			// Less Common Cases with Dictionaries
			// ----------------------------------------

			// Declaring and initializing a Dictionary (one-line version)
			Dictionary<string, string> usernamesAndPasswords = new Dictionary<string, string>()
			{
				{ "meland", "password" },
				{ "heland", "password" },
				{ "wes", "sw0rdf1sh" }
			};

			// Iterate through the key-value pairs in the Dictionary (You will RARELY do this)
			foreach (KeyValuePair<string, string> pair in usernamesAndPasswords)
            {
				Console.WriteLine(pair.Key + " has a password of " + pair.Value);
            }

			Console.WriteLine("Please enter your username");
			string username = Console.ReadLine();
			username = username.ToLower();

			Console.WriteLine("Please enter your password");
			string password = Console.ReadLine();

			if (usernamesAndPasswords.ContainsKey(username))
			{
				if (password == usernamesAndPasswords[username]) // check what the user typed in against the stored password for that user
				{
					Console.WriteLine("Access Granted");
				}
				else
				{
					Console.WriteLine("That's not that user's password!");
				}
			} 
			else
            {
				Console.WriteLine("That's not that user's password!");
            }

			// usernamesAndPasswords["meland"] == "password"

			// Retrieving just the keys from a Dictionary (You will RARELY do this)
			Console.WriteLine("Current Users of the System:");
			foreach (string key in usernamesAndPasswords.Keys)
            {
				Console.WriteLine(key);
            }

			// Null Reference Exceptions

			string externalUsername = null; // Pretend that this comes from another system and can be null

			if (externalUsername != null)
			{
				externalUsername = externalUsername.ToLower();

				if (usernamesAndPasswords.ContainsKey(externalUsername))
				{
					// Some other logic goes here
				}
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
			emailAddresses.Add("Vinny@TechElevator.com");

			// Removing from hash sets
			emailAddresses.Remove("Vinny@TechElevator.com");
			emailAddresses.Remove("ben@techelevator.com");

			// Checking if something is in a hash set
			if (emailAddresses.Contains("john@techelevator.com"))
            {
				Console.WriteLine("John is about to get some spam");
            }

			// Looping over a hash set
			foreach (string email in emailAddresses)
            {
				Console.WriteLine("Now spamming " + email);
            }
		}
	}
}
