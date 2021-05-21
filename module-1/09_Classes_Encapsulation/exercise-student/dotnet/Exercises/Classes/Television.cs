namespace Exercises.Classes
{
    public class Television


    {

        //PROPERTIES

        public bool IsOn { get; private set; } = false;

        public int CurrentChannel { get; private set; } = 3;

        public int CurrentVolume { get; private set; } = 2;


        //METHODS

        public void TurnOff()
        {
            this.IsOn = false;
        }

        public void TurnOn()
        {
            this.IsOn = true;
            this.CurrentChannel = 3;
            this.CurrentVolume = 2;
        }

        public void ChangeChannel(int newChannel)
        {
            if ((this.IsOn == true) && (newChannel >= 3) && (newChannel <= 18))
            {
                this.CurrentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if (this.IsOn == true)
            {
                if ((this.CurrentChannel + 1) > 18)
                {
                    this.CurrentChannel = 3;
                }
                else
                {
                    this.CurrentChannel++;
                }
            }
        }

        public void ChannelDown()
        {
            if (this.IsOn == true)
            {
                if ((this.CurrentChannel - 1) < 3)
                {
                    this.CurrentChannel = 18;
                }
                else
                {
                    this.CurrentChannel--;
                }
            }
        }

        public void RaiseVolume()
        {
            if (this.IsOn == true)
            {
                if (this.CurrentVolume+1 > 10) 
                {
                    CurrentVolume = 10;
                }
                else
                {
                    CurrentVolume++;
                }
            }
        }

        public void LowerVolume()
        {
            if (this.IsOn == true)
            {
                if (this.CurrentVolume - 1 < 0)
                {
                    CurrentVolume = 0;
                }
                else
                {
                    CurrentVolume--;
                }
            }
        }


    }
}
