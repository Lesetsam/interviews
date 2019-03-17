using Realmdigital_Interview.Models;
using System.Collections.Generic;

namespace Realmdigital_Interview.Repositories
{
    public interface IProductRepository
    {
        List<ApiResponseProduct> GetProductById(string productId);
        List<ApiResponseProduct> GetProductsByName(string productName);
    }
}
