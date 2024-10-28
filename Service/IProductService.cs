using Baby_ShoppingOnline.Entity;

namespace Baby_ShoppingOnline.Service;
public interface IProductService
{
    IEnumerable<Category> GetCategories();
    IEnumerable<Product> GetFeaturedProducts();
}
