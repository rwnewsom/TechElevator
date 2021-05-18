using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        InterleaveLists( [7, 1, 3], [2, 5, 7, 9] )  ->  [7, 2, 1, 5, 3, 7, 9]
        InterleaveLists( [1, 2, 5, 8], [4, 5, 6] )  ->  [1, 4, 2, 5, 5, 6, 8]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            //create a list, store count of sources
            List<int> longList = new List<int>();
            List<int> shortList = new List<int>();
            List<int> blendedList = new List<int>();
            //designate one list as 'longer'
            if (listOne.Count > listTwo.Count)
            {
                longList = listOne;
                shortList = listTwo;
            } else
            {
                longList = listTwo;
                shortList = listOne;
            }

            //initial loop counts through length of shorter list            
            for (int i = 0; i < shortList.Count; i++)
            {
                blendedList.Add(listOne[i]);
                blendedList.Add(listTwo[i]);
            }
            //determine difference in count if any...
            int delta = longList.Count - shortList.Count;
            //if arrays are equal the following loop won't run
            for (int j = longList.Count - delta; j < longList.Count; j++)
            {
                blendedList.Add(longList[j]);
            }
            return blendedList;
        }
    }
}
