using Realmdigital_Interview.Models;
using Realmdigital_Interview.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace Realmdigital_Interview.Controllers
{
    public class ProductController
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }


        [Route("product")]
        public ApiResponseProduct GetProductById(string productId)
        {
            var responseObject = _repository.GetProductById(productId);

            var result = FilterPriceByCurrencyZar(responseObject);

            return result.Count > 0 ? result[0] : null;
        }

        [Route("product/search")]
        public List<ApiResponseProduct> GetProductsByName(string productName)
        {
            var responseObject = _repository.GetProductsByName(productName);

            var result = FilterPriceByCurrencyZar(responseObject);

            return result;
        }

        private static List<ApiResponseProduct> FilterPriceByCurrencyZar(List<ApiResponseProduct> responseObject)
        {
            var result = new List<ApiResponseProduct>();

            foreach (var product in responseObject)
            {
                var prices = new List<ApiResponsePrice>();
                foreach (var price in product.PriceRecords)
                {
                    if (price.CurrencyCode == "ZAR")
                    {
                        prices.Add(price);
                    }
                }

                ApiResponseProduct prod = new ApiResponseProduct(product.BarCode, product.ItemName, prices);
                result.Add(prod);
            }

            return result;
        }
    }

}