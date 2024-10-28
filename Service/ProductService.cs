using Baby_ShoppingOnline.Entity;

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
        new Category { CategoryId = 1, CategoryName = "Electronics", Description = "Electronic gadgets" },
        new Category { CategoryId = 2, CategoryName = "Books", Description = "Fiction and non-fiction books" }
    };

        private List<Product> products = new List<Product>
    {
        new Product { ProductId = 1, ProductName = "Smartphone", Image = "", CreatedBy = "thaolent", UpdatedBy = "thaolent", RefCategoryId = new Category{CategoryName = "", Description = ""}},
        new Product { ProductId = 2, ProductName = "iPhone 15 Pro max 256GB Blue nature", Image = "", CreatedBy = "thaolent", UpdatedBy = "thaolent", RefCategoryId = new Category{CategoryName = "", Description = ""}}
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
