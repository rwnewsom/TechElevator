using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class Ledger
    {
        private List<string> historyEntries = new List<string>();

        // _historyEntries
        // m_historyEntries
        // m_LStrHistoryEntries

        private PetManager pets;

        public Ledger(PetManager manager)
        {
            this.pets = manager;
        }

        public void NewPetAcquired(Pet pet)
        {
            string message = "Bought Pet " + pet.ToString() + " for " + pet.PurchasePrice;
            this.historyEntries.Add(message);
        }

        public void PetSold(Pet pet)
        {
            string message = "Sold Pet " + pet + " for " + pet.SalePrice;
            this.historyEntries.Add(message);
        }

        public double PotentialSalesOfAllPets
        {
            get
            {
                double total = 0;

                foreach (Pet pet in this.pets.AvailablePets)
                {
                    total += pet.SalePrice;
                }

                return total;
            }
        }

        public string[] SalesHistory
        {
            get
            {
                return this.historyEntries.ToArray();
            }
        }
    }
}
