namespace Exercises.Classes
{
    public class Airplane
    {
        //PROPERTIES

        public string PlaneNumber { get; private set; }

        public int TotalFirstClassSeats { get; private set; }

        public int BookedFirstClassSeats { get; private set; }

        public int AvailableFirstClassSeats
        {
            get
            {
                return this.TotalFirstClassSeats - this.BookedFirstClassSeats;
            }
        }

        public int TotalCoachSeats { get; private set; }

        public int BookedCoachSeats { get; private set; }

        public int AvailableCoachSeats
        {
            get
            {
                return this.TotalCoachSeats - this.BookedCoachSeats;
            }
        }

        //CONSTRUCTORS

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }


        //METHODS

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true)
            {
                if ((this.AvailableFirstClassSeats - (this.BookedFirstClassSeats + totalNumberOfSeats)) >= 0)
                {
                    this.BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
            }
            else if ((this.AvailableCoachSeats - (this.BookedCoachSeats + totalNumberOfSeats)) >= 0)
            {
                this.BookedCoachSeats += totalNumberOfSeats;
                return true;
            }

            return false;
        }

    }
}
