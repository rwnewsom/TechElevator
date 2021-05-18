using System;
using System.Collections.Generic;
// using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			int[] lottoNumbers = new int[3];
			lottoNumbers[0] = 4;
			lottoNumbers[1] = 6;
			lottoNumbers[2] = -8;

			int numLottoNumbers = lottoNumbers.Length;

			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<int> lottoList = new List<int>();
			lottoList.Add(4);
			lottoList.Add(6);
			lottoList.Add(-8);
			// Can't do this: lottoList.Add("Fourty Two");

			int numLottoListNumbers = lottoList.Count;

			List<string> pets = new List<string>();
			pets.Add("Jester");
			pets.Add("Honey");

			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			string jester = pets[0];
			pets[1] = "Toto"; // Changes "Honey" to "Toto"
			// Can't do this: pets[20] = "Index that doesn't exist";

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			List<double> gpas = new List<double>();
			gpas.Add(4.0);
			gpas.Add(3.8);
			gpas.Add(4.0);

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			List<string> colors = new List<string>();
			colors.Add("Blue");
			colors.Add("Green");
			colors.Insert(0, "Orange");
			colors.Insert(0, "Purple");

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			List<string> states = new List<string>();
			states.Add("Ohio");
			states.Add("Wisconsin");
			states.Add("Iowa");
			states.Add("Michigan");

			states.RemoveAt(1);
			states.Remove("Michigan");

			Console.WriteLine("####################");
			Console.WriteLine("Create a list using {} syntax");
			Console.WriteLine("####################");

			List<string> books = new List<string>() { "Jurassic Park", "sphere", "Timeline" };

			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			bool alreadyHaveIt = books.Contains("Sphere");

			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int bookIndex = books.IndexOf("Sphere");

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] bookArray = books.ToArray();

			Console.WriteLine("####################");
			Console.WriteLine("Arrays can be turned into lists");
			Console.WriteLine("####################");

			string[] menuItems = { "Pizza", "Stromboli", "Hot Pockets" };

			List<string> menuList = new List<string>(menuItems);

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			List<int> sportsJerseys = new List<int>();
			sportsJerseys.Add(23);
			sportsJerseys.Add(99);
			sportsJerseys.Add(35);
			sportsJerseys.Sort();

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			sportsJerseys.Reverse();

			Console.WriteLine("####################");
			Console.WriteLine("Finding the smallest number in a list");
			Console.WriteLine("####################");

			List<int> fortuneNumbers = new List<int> { 55, 8, -6, 0, 9006 };
			fortuneNumbers.Sort();
			int smallestNumber = fortuneNumbers[0];

			// Set an int to the first element's value
			int smallest = fortuneNumbers[0];

			// Loop over everything in the list
			for (int i=0; i<fortuneNumbers.Count; i++)
            {
				int value = fortuneNumbers[i];

				// If that number is smaller than our variable's value, the variable should now be that value
				if (value < smallest)
                {
					smallest = value;
                }
			}

			Console.WriteLine("####################");
			Console.WriteLine("Transforming a list to another list");
			Console.WriteLine("####################");

			List<int> streetAddresses = new List<int> { 1003, 1005, 42, 1600 }; // -> { false, false, true, true }

			// Create a list to store the bool values
			List<bool> isEven = new List<bool>();

			// Loop over addresses
			foreach (int address in streetAddresses)
			{
				// Check address % 2
				if (address % 2 == 0)
				{
					isEven.Add(true);
				}
				else
				{
					isEven.Add(false);
				}
			}

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			List<string> movies = new List<string>() { "The Shining", "Fargo", "Hackers", "Sneakers" };

			foreach (string movie in movies)
            {
				Console.WriteLine(movie);
            }
			
			for (int i = 0; i < movies.Count; i++)
            {
				string movie = movies[i];
				Console.WriteLine(movie);
            }

/*
            // Set an int to the first element's value
            int smallest = fortuneNumbers[0];

            // Loop over everything in the list
            for (int i = 0; i < fortuneNumbers.Count; i++)
            {
                int value = fortuneNumbers[i];

                // If that number is smaller than our variable's value, the variable should now be that value
                if (value < smallest)
                {
                    smallest = value;
                }
            }
*/


            Console.WriteLine("####################");
			Console.WriteLine("Modifying lists while looping over them is bad");
			Console.WriteLine("####################");
			Console.WriteLine();

			List<int> onlyOddNumbers = new List<int>() { 1, 2, 3, 4, 5 };
			List<int> thingsToRemove = new List<int>();

			// Loop over numbers
			foreach (int number in onlyOddNumbers)
			{
				// If a number is even, remove it
				if (number % 2 == 0)
                {
					// Can't do this! onlyOddNumbers.Remove(number);
					thingsToRemove.Add(number);
                }
			}

			foreach (int numberToRemove in thingsToRemove)
            {
				onlyOddNumbers.Remove(numberToRemove);
            }

			// Alternative (easier) approach:

			List<int> numbersToCheck = new List<int>() { 1, 2, 3, 4, 5 };
			List<int> numbersToKeep = new List<int>();

			// Loop over numbers
			foreach (int number in numbersToCheck)
			{
				// If a number is odd, add it to numbersToKeep
				if (number % 2 == 1)
                {
					numbersToKeep.Add(number);
                }
			}

			Console.WriteLine("####################");
			Console.WriteLine("       STACKS");
			Console.WriteLine("####################");
			Console.WriteLine();

			Stack<string> methodNames = new Stack<string>();
			methodNames.Push("StartCar");
			methodNames.Push("StartEngine");
			methodNames.Push("InjectGas");

			string lastMethod = methodNames.Pop();


			Console.WriteLine("####################");
			Console.WriteLine("       QUEUES");
			Console.WriteLine("####################");
			Console.WriteLine();

			Queue<string> conventionAttendees = new Queue<string>();
			conventionAttendees.Enqueue("Mario");
			conventionAttendees.Enqueue("Bowser");
			conventionAttendees.Enqueue("Solid Snake");

			string nextAttendee = conventionAttendees.Dequeue();

			Console.WriteLine("All done!");


			string language = "C#";

			if (language == "C#")
            {
				Console.WriteLine("Good language");
            } 
			else if (language == "F#")
            {
				Console.WriteLine("Matt loves it, but don't use it.");
            } 
			else
            {
				Console.WriteLine("That's probably a good language");
            }

			switch (language)
            {
				case "C#":
					Console.WriteLine("Good Language");
					break;

				case "F#":
					Console.WriteLine("Matt loves it...");
					break;

				default:
					Console.WriteLine("That's probably a good language");
					break;
            }
		}
	}
}
