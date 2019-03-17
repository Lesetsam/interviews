using Microsoft.AspNetCore.Mvc;
using RealmDigitalInterview.Core;
using RealmDigitalInterview.Core.Repositories;
using System.Collections.Generic;

namespace Realmdigital_Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "welcome" };
        }

        [HttpGet("{id}")]
        public ApiResponseProduct GetProductById(string productId)
        {
            var responseObject = _repository.GetProductById(productId);

            var result = FilterPriceByCurrencyZar(responseObject, "ZAR");

            return result.Count > 0 ? result[0] : null;
        }

        [HttpGet("search/{productName}")]
        public List<ApiResponseProduct> GetProductsByName(string productName)
        {
            var responseObject = _repository.GetProductsByName(productName);

            var result = FilterPriceByCurrencyZar(responseObject, "ZAR");

            return result;
        }


        private static List<ApiResponseProduct> FilterPriceByCurrencyZar(List<ApiResponseProduct> responseObject, string currency)
        {
            var result = new List<ApiResponseProduct>();

            foreach (var product in responseObject)
            {
                var prices = new List<ApiResponsePrice>();
                foreach (var price in product.PriceRecords)
                {
                    if (price.CurrencyCode == currency)
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