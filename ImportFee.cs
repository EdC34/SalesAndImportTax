using System;
using System.Collections.Generic;
using System.Text;

namespace SalesAndImportTax
{
    class ImportFee : IFee
    {
        const decimal IMPORT_FEE = 0.05m;

        public decimal CalculateFee(decimal baseprice)
        {
            return baseprice * IMPORT_FEE;
        }
    }
}
