namespace Exercises.Classes
{
    /// <summary>
    /// Creates a fruit tree object given a type of fruit and number of pieces available.
    /// </summary>
    public class FruitTree
    {
        public string TypeOfFruit { get; private set; }

        public int PiecesOfFruitLeft { get; private set; }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }

        /// <summary>
        /// Given desired pieces, validate that sufficient fruit is available. If so, adjust balance and return true.
        /// </summary>
        /// <param name="numberOfPiecesToRemove"></param>
        /// <returns></returns>
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (numberOfPiecesToRemove <= PiecesOfFruitLeft)
            {
                this.PiecesOfFruitLeft -= numberOfPiecesToRemove;
                return true; //we could pick the fruit
            }
            return false;
        }

    }
}
