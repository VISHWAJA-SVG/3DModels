using _3DModels.Models;
using _3DModels.Repository;
using System.Collections.Generic;


namespace _3DModels.Services
{
    public class ProductService
    {
        private readonly ProductRepo _productRepo;

        public ProductService(ProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public string CreateProduct(Product product)
        {
            return _productRepo.CreateProduct(product);
        }

        public string UpdateProduct(Product product)
        {
            return _productRepo.UpdateProduct(product);
        }

        public string DeleteProductById(int id)
        {
            return _productRepo.DeleteProductById(id);
        }
    }
}

