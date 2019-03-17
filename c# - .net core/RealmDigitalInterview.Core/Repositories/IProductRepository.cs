using System.Collections.Generic;

namespace RealmDigitalInterview.Core.Repositories
{
    public interface IProductRepository
    {
        List<ApiResponseProduct> GetProductById(string productId);
        List<ApiResponseProduct> GetProductsByName(string productName);
    }
}
