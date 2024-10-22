using Baby_ShoppingOnline.Models;

namespace Baby_ShoppingOnline.Entity;

public class Rating
{
    public int RatingId { get; set; }
    public required Product RefProductId { get; set; }

    public required string Comment { get; set; }
    public int Point { get; set; }

}
