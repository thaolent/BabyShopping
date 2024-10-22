using Baby_ShoppingOnline.Models;

namespace Baby_ShoppingOnline.Service
{
    public class ProductService : IProductService
    {
        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetFeaturedProducts()
        {
            throw new NotImplementedException();
        }

        private List<Category> categories = new List<Category>
    {
        new Category { Id = 1, Name = "Electronics", Description = "Electronic gadgets" },
        new Category { Id = 2, Name = "Books", Description = "Fiction and non-fiction books" }
    };

        private List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Smartphone", Description = "Latest model smartphone", Price = 699, ImageUrl = "/images/smartphone.jpg", CategoryId = 1 },
        new Product { Id = 2, Name = "Laptop", Description = "High-performance laptop", Price = 999, ImageUrl = "/images/laptop.jpg", CategoryId = 1 }
    };

        public IEnumerable<Category> GetCategories1()
        {
            return categories;
        }

        public IEnumerable<Product> GetFeaturedProducts1()
        {
            return products.Take(2);
        }
    }
}
