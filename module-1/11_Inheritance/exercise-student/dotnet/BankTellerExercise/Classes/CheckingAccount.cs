namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        //CONSTRUCTORS       

        public CheckingAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        //METHOD OVERRIDE
        public override decimal Withdraw(decimal amountToWithdraw)
        {

            if ((this.Balance - amountToWithdraw) >= 0)
            {
                return base.Withdraw(amountToWithdraw);
            }

            if (amountToWithdraw > this.Balance)
            //overdraft protocol
            {
                if ((this.Balance - amountToWithdraw) > -100)
                {
                    Withdraw(10);
                    return Withdraw(amountToWithdraw);
                } 
            }
            return Withdraw(0);



        }
    }
}
