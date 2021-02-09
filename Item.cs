using System;
using System.Collections.Generic;
using System.Text;

namespace SalesAndImportTax
{
    public class Item
    {
        public string Name { get; set; }
        public decimal BasePrice { get; private set; }

        private IEnumerable<IFee> Fees { get; set; }

        public Item(string name, decimal baseprice) : this(name, baseprice, new List<IFee>())
        {
        }
        public Item(string name, decimal baseprice, IEnumerable<IFee> fees)
        {
            Name = name;
            BasePrice = baseprice;
            Fees = fees;
        }
        public decimal GetBasePrice() {
            decimal fullBasePrice = BasePrice;

            foreach(IFee fee in Fees)
            {
                fullBasePrice += fee.CalculateFee(BasePrice);
            }
            return fullBasePrice;
        }
        

    }
}
