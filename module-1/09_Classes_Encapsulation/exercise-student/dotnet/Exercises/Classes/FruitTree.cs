namespace Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; private set; }

        public int PiecesOfFruitLeft { get; private set; }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }

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
