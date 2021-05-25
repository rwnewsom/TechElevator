namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {

        //CONSTRUCTORS

        /// <summary>
        /// Establish a new savings account with zero initial balance.
        /// </summary>
        /// <param name="accountHolderName">Legal name of account holder.</param>
        /// <param name="accountNumber">An account number with appropriate prefix.</param>
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {
            
            this.Balance = 0;
        }

        /// <summary>
        /// Establish a new checking account with an initial deposit.
        /// </summary>
        /// <param name="accountHolderName">Legal name of account holder.</param>
        /// <param name="accountNumber">An account number with appropriate prefix.</param>
        /// <param name="balance">The amount initially deposited.</param>
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {
           
        }


        //METHOD OVERRIDE

        /// <summary>
        /// Verifies account will remain above minimum free balance. Applies a fee if under minimum.  Denies if sufficient funds are unavailable.
        /// </summary>
        /// <param name="amountToWithdraw">The balance to be withdrawn.</param>
        /// <returns></returns>
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
            
        }
    }
}
