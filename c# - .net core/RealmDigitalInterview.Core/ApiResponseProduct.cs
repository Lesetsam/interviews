using System;
using System.Collections.Generic;
using System.Text;

namespace RealmDigitalInterview.Core
{
    public class ApiResponseProduct
    {
        public ApiResponseProduct(string barCode, string itemName, List<ApiResponsePrice> prices)
        {
            BarCode = barCode;
            ItemName = itemName;
            PriceRecords = prices;
        }

        public string BarCode { get; }
        public string ItemName { get; }
        public List<ApiResponsePrice> PriceRecords { get; }
    }
}
