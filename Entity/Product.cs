using Baby_ShoppingOnline.Models;

namespace Baby_ShoppingOnline.Entity;

public class Product
{
    public int ProductId { get; set; }
    public required string ProductName { get; set; }
    public required Category RefCategoryId  { get; set; }

    public string Description { get; set; } = String.Empty;

    public decimal AveragePoint { get; set; }
= 0;
    public decimal Price { get; set; }
= 0;
    public required String Image { get; set; }

    public DateTime CreatedDate { get; set; }

    public required String CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public required String UpdatedBy { get; set; }

}
