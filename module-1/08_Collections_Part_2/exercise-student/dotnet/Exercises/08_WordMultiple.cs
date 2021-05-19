using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, bool> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         *
         * WordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * WordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * WordMultiple(["c", "c", "c", "c"]) → {"c": true}
         *
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, bool> moreWords = new Dictionary<string, bool>();

            foreach(string word in words)
            {
                if (!moreWords.ContainsKey(word))
                {
                    moreWords[word] = false;
                }
                else
                {
                    moreWords[word] = true;
                }
            }
            return moreWords;
            //add as false as first time.
            //if found, update value to true
        }
    }
}
