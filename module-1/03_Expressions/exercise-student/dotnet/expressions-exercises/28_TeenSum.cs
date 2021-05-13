namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 ints, a and b, return their sum. However, "teen" values in the range 13..19 inclusive, are
         extra lucky. So if either value is a teen, just return 19.
         TeenSum(3, 4) → 7
         TeenSum(10, 13) → 19
         TeenSum(13, 2) → 19
         */

        public bool IsTeen(int x)
        {
            if ((x>=13) && (x <= 19))
            {
                return true;
            }
            return false;
        }

        public int TeenSum(int a, int b)
        {
            if(IsTeen(a) || IsTeen(b))
            {
                return 19;
            }
            return a+b;
        }
    }
}
