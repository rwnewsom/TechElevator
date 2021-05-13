namespace Lecture
{
    public partial class LectureExample
    {
        /*
         9. How can we rewrite exercise 8 to have only one line of code?
            TOPIC: Boolean Expression & Comparison Operators
        */
        public bool ReturnTrueWhenGreaterThanFiveInOneLine(int number)
        {
            if (number > 5) { return true; } return false;
            //return false; // What can we put here that returns a bool that we want?
        }
    }
}
