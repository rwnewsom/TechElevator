﻿namespace Lecture
{
    public partial class LectureExample
    {
        /*
        15. Now, do it again with a different bool opeation.
        TOPIC: Logical Not
        */
        public string ReturnAdultOrMinorAgain(int number)
        {
            if (!(number<18))
            {
                return "Adult";
            }
            else
            {
                return "Minor";
            }
        }
    }
}
