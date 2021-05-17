namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, return a larger string that is n copies of the original string.
        StringTimes("Hi", 2) → "HiHi"
        StringTimes("Hi", 3) → "HiHiHi"
        StringTimes("Hi", 1) → "Hi"
        */
        public string StringTimes(string str, int n)
        {
            if (n == 0)
            {
                return "";
            }
            string newString = str;
            for (int i=0; i<n-1; i++)
            {
                newString += str;
            }
            return newString;
        }
    }
}
