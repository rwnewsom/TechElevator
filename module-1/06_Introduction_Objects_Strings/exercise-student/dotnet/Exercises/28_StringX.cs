namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            if (str.Length <= 2)
            {
                return str;
            }
            string firstPsn = str.Substring(0, 1);
            string lastPsn = str.Substring(str.Length - 1, 1);
            string middleText = str.Substring(1, str.Length - 2);
            string xPurged = middleText.Replace("x", "");
            return firstPsn+xPurged+lastPsn;
        }
    }
}
