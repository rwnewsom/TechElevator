using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsPart2Lecture
{
    public class CollectionsReviewScratch
    {
        public void LectureReview()
        {
            List<string> colors = new List<string>();
            colors.Add("Purple");
            colors.Add("Steel Blue");
            colors.Add("Dark Clear");
            colors.Add("Orange");

            // Foreach vs For
            for (int i = 0; i < colors.Count; i++)
            {
                string color = colors[i];

                Console.WriteLine(color);
            }

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Storing an Int in a List of Strings
            int number = 4;
            List<string> fizzBuzzAnswers = new List<string>();
            fizzBuzzAnswers.Add(number.ToString()); // "4"

            // Dictionary Example
            Dictionary<string, int> speedingOffenses = new Dictionary<string, int>();

            for (int i = 0; i < 42; i++)
            {
                // Check to see if they know about me (if I have any prior entries)
                if (speedingOffenses.ContainsKey("T00 F4ST"))
                {
                    speedingOffenses["T00 F4ST"] = speedingOffenses["T00 F4ST"] + 1;
                }
                else
                {
                    speedingOffenses["T00 F4ST"] = 1;
                }
            }

            int clientsSpeedingTickets = speedingOffenses["T00 F4ST"];
        }
    }
}
