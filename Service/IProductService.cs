using Baby_ShoppingOnline.Models;

namespace Baby_ShoppingOnline.Service
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Product> GetFeaturedProducts();
    }
}
