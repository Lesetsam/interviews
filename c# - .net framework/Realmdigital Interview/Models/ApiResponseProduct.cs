using System.Collections.Generic;

namespace Realmdigital_Interview.Models
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