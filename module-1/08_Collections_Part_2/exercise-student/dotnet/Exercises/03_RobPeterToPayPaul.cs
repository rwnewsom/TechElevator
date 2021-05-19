using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         *
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         *
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         *
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {
            //create a new dictionary and transfer value
            //clunkier than it should be, refactored repeatedly before realizing
            //that I had used an incorrect angle bracket to check paul's wallet!

            if((peterPaul["Peter"] > 0) && (peterPaul["Paul"] < 10000))
            {
                int peterWallet = peterPaul["Peter"];
                int paulWallet = peterPaul["Paul"];
                int peterLoss = peterWallet / 2;
                peterWallet -= peterLoss;
                paulWallet += peterLoss;
                peterPaul["Peter"] = peterWallet;
                peterPaul["Paul"] = paulWallet;
            }

            
            
            
            return peterPaul;
        }
    }
}
