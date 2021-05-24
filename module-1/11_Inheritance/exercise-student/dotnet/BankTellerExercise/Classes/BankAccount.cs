namespace BankTellerExercise.Classes
{
    
    /// <summary>
    /// This class represents transactional accounts.
    /// </summary>
    public class BankAccount
    {
        //PROPERTIES

        public string AccountHolderName { get; protected set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; protected set; }


        //CONSTRUCTORS
        /// <summary>
        /// Establishes a new account with zero balance.
        /// </summary>
        /// <param name="accountHolderName">Legal name of account holder.</param>
        /// <param name="accountNumber">An account number with appropriate prefix.</param>
        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }
        /// <summary>
        /// Establishes a new account with an initial deposit.
        /// </summary>
        /// <param name="accountHolderName">Legal name of account holder.</param>
        /// <param name="accountNumber">An account number with appropriate prefix.</param>
        /// <param name="balance">The amount initially deposited.</param>
        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public BankAccount()
        {

        }


        //METHODS

        /// <summary>
        /// Deposit funds to existing account.
        /// </summary>
        /// <param name="amountToDeposit">The balance to be deposited.</param>
        /// <returns></returns>
        public decimal Deposit(decimal amountToDeposit)
        {
            return this.Balance += amountToDeposit;            
        }


        /// <summary>
        /// Withdraw funds from an existing account.
        /// </summary>
        /// <param name="amountToWithdraw">The balance to be withdrawn.</param>
        /// <returns></returns>
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return this.Balance -= amountToWithdraw;
        }
    }
}
