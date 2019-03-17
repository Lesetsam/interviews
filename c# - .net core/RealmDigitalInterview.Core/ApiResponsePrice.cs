using System;
using System.Collections.Generic;
using System.Text;

namespace RealmDigitalInterview.Core
{
    public class ApiResponsePrice
    {
        public ApiResponsePrice(string sellingPrice, string currencyCode)
        {
            SellingPrice = sellingPrice;
            CurrencyCode = currencyCode;
        }


        public string SellingPrice { get; }
        public string CurrencyCode { get; }

    }
}
