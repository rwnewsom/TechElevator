namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return a string made of the middle two chars, so the string "string"
        yields "ri". The string length will be at least 2.
        MiddleTwo("string") → "ri"
        MiddleTwo("code") → "od"
        MiddleTwo("Practice") → "ct"
        */
        public string MiddleTwo(string str)
        {
            if (str.Length <= 2)
            {
                return str;
            }
            if (str.Length == 3)
            {
                return str.Substring(1, 1);
            }
            string firstHalf = str.Substring(0, str.Length / 2);
            string secondHalf = str.Substring(str.Length/2);
            string firstSub = firstHalf.Substring(firstHalf.Length - 1, 1);
            string secondSub = secondHalf.Substring(0, 1);
            return firstSub + secondSub;
        }
    }
}
