namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        //PROPERTIES

        public string AccountHolderName { get; protected set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; protected set; }


        //CONSTRUCTORS

        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }

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

        public decimal Deposit(decimal amountToDeposit)
        {
            return this.Balance += amountToDeposit;            
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            return this.Balance -= amountToWithdraw;
        }
    }
}
