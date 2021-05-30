using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }

        public override string ToString()
        {
            return this.Name + " the " + this.Type;
        }
    }
}
