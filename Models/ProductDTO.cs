using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baby_ShoppingOnline.Models;
public class ProductDTO
{
    public required int ProductId { get; set; }
    public required string ProductName { get; set; }
    public required int RefCategoryId  { get; set; }

    public string Description { get; set; } = String.Empty;

    public required decimal Price { get; set; }
    public required String Image { get; set; }
}