using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses
{
    public class EntryTracker
    {
        public int NumberOfPeople { get; private set; }

        public void EntryDoorOpened()
        {
            this.NumberOfPeople++;
        }

        public void ExitDoorOpened()
        {
            this.NumberOfPeople--;

            if (this.NumberOfPeople < 0)
            {
                this.NumberOfPeople = 0;
            }
        }
    }
}
