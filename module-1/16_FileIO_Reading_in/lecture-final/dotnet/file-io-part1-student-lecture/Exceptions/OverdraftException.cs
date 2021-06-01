using System;

namespace FileInputLecture
{
    public class OverdraftException : ApplicationException
    {
        private double overdraftAmount = 0.0;
        public double OverdraftAmount
        {
            get { return overdraftAmount; }
        }

        public OverdraftException(string message, double overdraftAmount)
            : base(message)
        {
            this.overdraftAmount = overdraftAmount;
        }
    }

    public class NegativeWithdrawalException : ApplicationException
    {
        public NegativeWithdrawalException(string message) : base(message)
        {

        }
    }
}
