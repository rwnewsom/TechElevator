namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        
        public bool InRange1(int x)
        {
            if((x >= 30 && x <= 40))
            {
                return true;
            }
            return false;
        }

        public bool InRange2(int y)
        {
            if ((y >= 40 && y <= 50))
            {
                return true;
            }
            return false;

        }

        public bool In3050(int a, int b)
        {
            if((InRange1(a)) && (InRange1(b)))
            {
                return true;
            }
            else if((InRange2(a)) && (InRange2(b)))
            {
                return true;
            }
                return false;
        }
    }
}
