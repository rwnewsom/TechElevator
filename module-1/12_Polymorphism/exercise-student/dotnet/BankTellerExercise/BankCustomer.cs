using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {
        //ATTRIBUTES
        public string Name { get; private set; }
        public string Address { get; private set; }

        public string PhoneNumber { get; private set;  }

        //making private
        private List<IAccountable> customerAccounts = new List<IAccountable>();

        public bool IsVip { get
            {
                decimal netWorth = 0;


                foreach (IAccountable curAccount in customerAccounts)
                {
                    netWorth += curAccount.Balance;
                }
                if(netWorth >= 25000)
                {
                    return true;
                }
                return false;
            } 
        }

        //METHODS

        public void AddAccount(IAccountable newAccount)
        {
            customerAccounts.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return this.customerAccounts.ToArray();
        }

    }
}


/*List<ISingable> animals = new List<ISingable>();
            animals.Add(new Chicken());
            animals.Add(new Goat());
            animals.Add(new Sheep());
            animals.Add(new Tractor());
*/
