namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            int xIndex = str.IndexOf("x");
            if (str.Length - (xIndex + 1) < 1)
            {
                return false;
            }
            if (str.Substring(xIndex+1,1) == "x")
            {
                return true;
            }
            return false;
        }
    }
}
