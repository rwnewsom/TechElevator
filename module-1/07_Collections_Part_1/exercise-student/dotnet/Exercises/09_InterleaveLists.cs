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

            List<int> hellList = new List<int>();
            int countOne = listOne.Count;
            int countTwo = listTwo.Count;
            //initial loop counts through shorter list
            //add both value in turn

            //add if both are same size!!!!!!

            if (countOne == countTwo)
            {
                for (int i = 0; i < countTwo; i++)
                {
                    hellList.Add(listOne[i]);
                    hellList.Add(listTwo[i]);
                }
                return hellList;

            }

            else if (countOne > countTwo)
            {
                int delta = countOne - countTwo;
                for (int i = 0; i < countTwo; i++)
                {
                    hellList.Add(listOne[i]);
                    hellList.Add(listTwo[i]);
                    //if last of shortest, loop through remaining larger
                    if ((i + 1) >= countTwo)
                    {
                        //determine remaining values to add


                        for (int j = countOne-delta; j < countOne; j++)
                        {
                            hellList.Add(listOne[j]);
                        }

                    }

                }
                return hellList;

            }
            //as above but if sizes are reversed
            else
            {
                int delta = countTwo - countOne;
                for (int i = 0; i < countOne; i++)
                {
                    hellList.Add(listOne[i]);
                    hellList.Add(listTwo[i]);
                    if ((i + 1) >= countOne)
                    {
                        
                        for (int j = countTwo-delta; j < countTwo; j++)
                        {
                            hellList.Add(listTwo[j]);
                        }

                    }

                }
                return hellList;

            }


        }
    }
}
