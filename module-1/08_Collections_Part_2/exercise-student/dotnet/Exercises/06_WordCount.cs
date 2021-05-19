using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
         * number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            //loop through
            //check if dictionary Contains
            //if not, add, if it does, update value

            Dictionary<string, int> wordFreq = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if((word!=null)&&(word != ""))
                {
                    if (!wordFreq.ContainsKey(word))
                    {
                        wordFreq[word] = 1;
                    }
                    else
                    {
                        wordFreq[word]++;
                    }
                }
            }
            
            return wordFreq;
        }
    }
}
