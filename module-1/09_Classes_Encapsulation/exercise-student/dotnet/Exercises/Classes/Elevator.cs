namespace Exercises.Classes
{
    public class Elevator
    {

        /// <summary>
        /// Guardian pattern for previously analog elevator controls
        /// </summary>

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

        /// <summary>
        /// Verifies that the door is closed and destination is valid; if so, goes to desired floor.
        /// </summary>
        /// <param name="desiredFloor">Pretty self explanatory...</param>
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


        /// <summary>
        /// Verifies that the door is closed and destination is valid; if so, goes to desired floor.
        /// </summary>
        /// <param name="desiredFloor">Pretty self explanatory...</param>
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
