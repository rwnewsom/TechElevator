﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given three int values, a b c, return the largest.
        IntMax(1, 2, 3) → 3
        IntMax(1, 3, 2) → 3
        IntMax(3, 2, 1) → 3
        */
        public int IntMax(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    return b;
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    return c;
                }
            }

            return 0;
        }
    }
}
