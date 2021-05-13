namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */

        public bool InRange(int x)
        {
            if ((x >= 10 && x <= 20))
            {
                return true;
            }
            return false;
        }



        public int Max1020(int a, int b)
        {
            if ((InRange(a))&& (InRange(b)))
            {
                if (a > b)
                {
                    return a;
                } return b;
            }
            else if (InRange(a))
            {
                return a;
            }
            else if (InRange(b))
            {
                return b;
            }
            return 0;
        }
    }
}
