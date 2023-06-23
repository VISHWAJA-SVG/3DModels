using _3DModels.Models;
using System.Collections.Generic;
using System.Linq;


namespace _3DModels.Repository
{
    public class ProductRepo : IProduct
    {
        private readonly ModelDbContext _dbContext;

        public ProductRepo(ModelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public string CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return "Product created successfully.";
        }

        public string UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return "Product updated successfully.";
        }

        public string DeleteProductById(int id)
        {
            var product = _dbContext.Products.Find(id);
            if (product == null)
            {
                return "Product not found.";
            }

            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
            return "Product deleted successfully.";
        }
    }
}


