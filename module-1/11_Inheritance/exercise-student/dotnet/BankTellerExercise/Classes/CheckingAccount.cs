namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        //CONSTRUCTORS       

        /// <summary>
        /// Establish a new checking account with zero initial balance.
        /// </summary>
        /// <param name="accountHolderName">Legal name of account holder.</param>
        /// <param name="accountNumber">An account number with appropriate prefix.</param>
        public CheckingAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }
        /// <summary>
        /// Establishes a new checking account with an initial deposit.
        /// </summary>
        /// <param name="accountHolderName">Legal name of account holder.</param>
        /// <param name="accountNumber">An account number with appropriate prefix.</param>
        /// <param name="balance">The amount initially deposited.</param>
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }


        /// <summary>
        /// Verifies sufficient funds are available and permits; denies; or allows overdraw for fee.
        /// </summary>
        /// <param name="amountToWithdraw">The balance to be withdrawn.</param>
        /// <returns></returns>
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
                    base.Withdraw(10);
                    return base.Withdraw(amountToWithdraw);
                } 
            }
            return base.Withdraw(0);



        }
    }
}
