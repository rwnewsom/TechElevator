using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        //ATTRIBUTES

        public string AccountHolderName { get; }

        public string AccountNumber { get; }

        public int Debt
        {
            get
            {
                return -this.Balance;
            }
        }

        public int Balance { get; private set; }

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = 0;

        }


        //METHODS

        public int Pay (int amountToPay)
        {
            this.Balance += amountToPay;
            return this.Balance;
        }

        public int Charge (int amountToCharge)
        {
            this.Balance -= amountToCharge;
            return this.Balance;
        }

    }
}
