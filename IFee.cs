using System;
using System.Collections.Generic;
using System.Text;

namespace SalesAndImportTax
{
    public interface IFee
    {
        decimal CalculateFee(decimal baseprice);
    }
}
