namespace Realmdigital_Interview.Models
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