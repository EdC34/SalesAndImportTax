using System;
using System.Collections.Generic;
using System.Text;

namespace SalesAndImportTax
{
    class TaxFee : IFee
    {
        const decimal TAX_RATE = 0.10m;
        
        public decimal CaclulateFee(decimal baseprice)
        {
            return baseprice * TAX_RATE;
        }

        public decimal CalculateFee(decimal baseprice)
        {
            throw new NotImplementedException();
        }
    }
}
