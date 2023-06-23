using _3DModels.Models;
using System.Collections.Generic;


namespace _3DModels.Repository
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        string CreateProduct(Product product);
        string UpdateProduct(Product product);
        string DeleteProductById(int id);
    }
}

