namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {

        //CONSTRUCTORS

        public SavingsAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }

        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }


        //METHOD OVERRIDE

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if ((this.Balance - amountToWithdraw) >= 150)
            {
                return base.Withdraw(amountToWithdraw);
            } 
            
            else if ((this.Balance - amountToWithdraw) >= 2)
            {
                base.Withdraw(2);
                return base.Withdraw(amountToWithdraw);
            }

            else
            {
                return base.Withdraw(0);
            }
            
            //return base.Withdraw(amountToWithdraw);
        }
    }
}
