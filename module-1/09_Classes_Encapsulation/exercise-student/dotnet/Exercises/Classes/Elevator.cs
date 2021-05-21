namespace Exercises.Classes
{
    public class Elevator
    {
        //PROPERTIES
        public int CurrentLevel { get; private set; } = 1;

        public int NumberOfLevels { get; private set; }

        public bool DoorIsOpen { get; private set; }

        //CONSTRUCTOR

        public Elevator(int numberOfLevels)
        {
            this.NumberOfLevels = numberOfLevels;
        }

        //METHODS

        public void OpenDoor()
        {
            this.DoorIsOpen = true;
        }

        public void CloseDoor()
        {
            this.DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen)
            {
                if ((desiredFloor <= this.NumberOfLevels) && (this.CurrentLevel<desiredFloor))
                {
                    this.CurrentLevel = desiredFloor;
                }
            }
        }

        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen)
            {
                if ((desiredFloor <= this.NumberOfLevels) && (desiredFloor>0) && (this.CurrentLevel > desiredFloor))
                {
                    this.CurrentLevel = desiredFloor;
                }
            }
        }


    }
}
