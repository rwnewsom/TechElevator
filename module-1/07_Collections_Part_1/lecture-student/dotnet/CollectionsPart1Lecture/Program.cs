using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<int> lottoList = new List<int>();
			lottoList.Add(4);
			lottoList.Add(6);
			lottoList.Add(-8);

			List<string> pets = new List<string>();
			pets.Add("Jester");
			pets.Add("Honey");

			string jester = pets[0];
			pets[1] = "Toto";
			// can't do this: pets[20] = "index out of range"


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");



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

			List<string> books = new List<string>() { "Jurrasic Park", "Sphere", "Timeline" };

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



			Console.WriteLine("####################");
			Console.WriteLine("Transforming a list to another list");
			Console.WriteLine("####################");

			List<int> streetAddresses = new List<int>(){ 1003, 1005, 42, 1600 };

			List<int> evenAddresses = new List<int>();

			foreach(int addie in streetAddresses)
            {
				if (addie % 2 == 0)
                {
					evenAddresses.Add(addie);
                }
            }



			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			List<string> movies = new List<string>() { "The Shining", "Fargo", "Hackers", "Sneakers" };

			foreach(string movie in movies)
            {
				Console.WriteLine(movie);
            }



			Console.WriteLine("####################");
			Console.WriteLine("Modifying lists while looping over them is bad");
			Console.WriteLine("####################");
			Console.WriteLine();

			/*
			List<int> onlyOddNumbers = new List<int>() { 1, 2, 3, 4, 5 };
			foreach (int number in onlyOddNumbers)
            {
                if (number % 2 == 0)
                {
					onlyOddNumbers.Remove(number);
                }
            }
			*/


			Console.WriteLine("####################");
			Console.WriteLine("       STACKS");
			Console.WriteLine("####################");
			Console.WriteLine();

			Stack<string> methodNames = new Stack<string>();
			methodNames.Push("Start Car");
			methodNames.Push("Start Engine");
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

			string nextAttendee = conventionAttendees.Dequeue(); //mario

			string language = "C#";

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
