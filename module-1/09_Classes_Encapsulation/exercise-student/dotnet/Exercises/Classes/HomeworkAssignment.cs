namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }

        public int PossibleMarks { get; private set; }

        public string SubmitterName { get; private set; }

        public string LetterGrade
        {
            get
            {
                if (EarnedMarks >= (PossibleMarks * .9))
                {
                    return "A";
                }
                if (EarnedMarks >= (PossibleMarks * .8))
                {
                    return "B";
                }
                if (EarnedMarks >= (PossibleMarks * .7))
                {
                    return "C";
                }
                if (EarnedMarks >= (PossibleMarks * .6))
                {
                    return "D";
                }
                return "F";
            }




        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }

    }
}
