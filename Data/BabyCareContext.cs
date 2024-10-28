using Baby_ShoppingOnline.Entity;
using Microsoft.EntityFrameworkCore;

namespace Baby_ShoppingOnline.Data;

public class BabyCareContext(DbContextOptions<BabyCareContext> options) : DbContext(options)
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Rating> Ratings => Set<Rating>();
    public DbSet<Account> Accounts => Set<Account>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new {CategoryId= 1, CategoryName = "Diapers", Description = "Diaper for infant and baby"},
            new {CategoryId= 2, CategoryName = "Powdered Milk", Description = "A dairy product made by evaporating milk to dryness"},
            new {CategoryId= 3, CategoryName = "Reconstituted milk", Description = "Mixing milk powder with water to create liquid milk"},
            new {CategoryId= 4, CategoryName = "Baby Food", Description = "This food is specifically made to meet the nutritional needs of infants and toddlers, ensuring they get the essential vitamins and minerals for proper growth and development"},
            new {CategoryId= 5, CategoryName = "Vitamins", Description = " vitamins are essential for their growth and development"}
        );

        modelBuilder.Entity<Product>().HasData(
            new{ProductId = 1, ProductName = "Huggies Nature Made", RefCategoryIdCategoryId = 1, Description = "Platinum", AveragePoint = 7.5m, Price = 195000.0m, Image = @"D:\.NET\BabyShopping_Image\Diaper\Huggies.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 2, ProductName = "Bobby", RefCategoryIdCategoryId = 1, Description = "Bobby for baby", AveragePoint = 5.0m, Price = 189900.0m, Image = @"D:\.NET\BabyShopping_Image\Diaper\bobby.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin" },
            new {ProductId = 3, ProductName = "Gooby", RefCategoryIdCategoryId = 1, Description = "Gooby Extra Newborn Little ", AveragePoint = 9.0m, Price = 205000.0m, Image = @"D:\.NET\BabyShopping_Image\Diaper\gooby.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 4, ProductName = "Nabizam", RefCategoryIdCategoryId = 1, Description = "Bland, soft fabric. - Ultra-soft fabric using the super-microfiber ", AveragePoint = 7.2m, Price = 234098.0m, Image = @"D:\.NET\BabyShopping_Image\Diaper\nabizam.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 5, ProductName = "Mamogom", RefCategoryIdCategoryId = 1, Description = "MAMOGOM Premium CARE ORGANIC KOREAN PREMIUM CARE  ", AveragePoint = 6.1m, Price = 245000.0m, Image = @"D:\.NET\BabyShopping_Image\Diaper\mamogom.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
        
            new{ProductId = 6, ProductName = "Aptamil", RefCategoryIdCategoryId = 2, Description = "Aptamil NewZeland", AveragePoint = 7.5m, Price = 195000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Powdered milk\aptamil_bac.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 7, ProductName = "Blackmores", RefCategoryIdCategoryId = 2, Description = "For infant", AveragePoint = 5.0m, Price = 189900.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Powdered milk\blackmore.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin" },
            new {ProductId = 8, ProductName = "ColosBaby", RefCategoryIdCategoryId = 2, Description = "Colos for baby", AveragePoint = 9.0m, Price = 205000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Powdered milk\colosbaby.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 9, ProductName = "Enfamil A+", RefCategoryIdCategoryId = 2, Description = "Well-cooked, pureed legumes such as beans, lentils and chickpeas.", AveragePoint = 7.2m, Price = 234098.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Powdered milk\enfamil.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 10, ProductName = "HiPP", RefCategoryIdCategoryId = 2, Description = "HiPP becomes Germany's third company and first food manufacturer", AveragePoint = 6.1m, Price = 245000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Powdered milk\hipp.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},

            new{ProductId = 11, ProductName = "Abott Grow", RefCategoryIdCategoryId = 3, Description = "Abott Grow", AveragePoint = 7.5m, Price = 195000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Liquid milk\abottgrow.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 12, ProductName = "Aptakid", RefCategoryIdCategoryId = 3, Description = "Aptakid", AveragePoint = 5.6m, Price = 189900.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Liquid milk\aptakid.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin" },
            new {ProductId = 13, ProductName = "ColosBaby", RefCategoryIdCategoryId = 3, Description = "Colos for baby", AveragePoint = 4.0m, Price = 205000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Liquid milk\colosbaby.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 14, ProductName = "DalatMilk", RefCategoryIdCategoryId = 3, Description = "DalatMilk", AveragePoint = 7.4m, Price = 123000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Liquid milk\dalatmilk.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 15, ProductName = "Vinamilk", RefCategoryIdCategoryId = 3, Description = "Vinamil Green farm", AveragePoint = 9.8m, Price = 134000.0m, Image = @"D:\.NET\BabyShopping_Image\Milk\Liquid milk\vinamilk xanh.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},

            new{ProductId = 16, ProductName = "Gerber Puffs", RefCategoryIdCategoryId = 4, Description = "Banh an dam", AveragePoint = 7.5m, Price = 195000.0m, Image = @"D:\.NET\BabyShopping_Image\Baby Food\banhandamGerber.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 17, ProductName = "BioKids", RefCategoryIdCategoryId = 4, Description = "Bot an dam vi lua mach", AveragePoint = 5.6m, Price = 189900.0m, Image = @"D:\.NET\BabyShopping_Image\Baby Food\botbiokid.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin" },
            new {ProductId = 18, ProductName = "Bot Heinz", RefCategoryIdCategoryId = 4, Description = "Bot an dam vij sua", AveragePoint = 4.0m, Price = 205000.0m, Image = @"D:\.NET\BabyShopping_Image\Baby Food\botHeinz.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 19, ProductName = "Bot HiPP Organic", RefCategoryIdCategoryId = 4, Description = "Bot an dam Hipp", AveragePoint = 7.4m, Price = 123000.0m, Image = @"D:\.NET\BabyShopping_Image\Baby Food\botHipp.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 20, ProductName = "Vang sua Hoff", RefCategoryIdCategoryId = 4, Description = "Vang sua trai cay", AveragePoint = 9.8m, Price = 134000.0m, Image = @"D:\.NET\BabyShopping_Image\Baby Food\vangsuahoff.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},

            new{ProductId = 21, ProductName = "BioGaia", RefCategoryIdCategoryId = 5, Description = "Men tieu hoa", AveragePoint = 7.5m, Price = 195000.0m, Image = @"D:\.NET\BabyShopping_Image\Vitamin\biogaia.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 22, ProductName = "Sunday Natural", RefCategoryIdCategoryId = 5, Description = "D3K2", AveragePoint = 5.6m, Price = 189900.0m, Image = @"D:\.NET\BabyShopping_Image\Vitamin\sunday natural.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin" },
            new {ProductId = 23, ProductName = "Fitobimbi", RefCategoryIdCategoryId = 5, Description = "An ngon ngu ngon", AveragePoint = 4.0m, Price = 205000.0m, Image = @"D:\.NET\BabyShopping_Image\Vitamin\fitobimbi.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 24, ProductName = "PediaKid", RefCategoryIdCategoryId = 5, Description = "MultiVitamins", AveragePoint = 7.4m, Price = 123000.0m, Image = @"D:\.NET\BabyShopping_Image\Vitamin\pediakid.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"},
            new {ProductId = 25, ProductName = "Kid Smart drops", RefCategoryIdCategoryId = 5, Description = "Probiotic", AveragePoint = 9.8m, Price = 134000.0m, Image = @"D:\.NET\BabyShopping_Image\Vitamin\pribiotic.jpg", CreatedDate = DateTime.Now, CreatedBy = "Admin", UpdatedDate = DateTime.Now, UpdatedBy = "Admin"}
        );

        modelBuilder.Entity<Account>().HasData(
            new{AccountId = 1, Username = "thaolent", Password = "12345678", Email = "thanhthao110889@gmail.com", Phone = "0982345167"},
            new{AccountId = 2, Username = "dungdq", Password = "12345678", Email = "kisshoang@gmail.com", Phone = "0982345168"}
        );

        modelBuilder.Entity<Rating>().HasData(
            new {RatingId = 1, RefProductIdProductId = 1, Comment = "This iss rating for product 1", Point = 5},
            new {RatingId = 2, RefProductIdProductId = 6, Comment = "This iss rating for product 6", Point = 7},
            new {RatingId = 3, RefProductIdProductId = 10, Comment = "This iss rating for product 10", Point = 8},
            new {RatingId = 4, RefProductIdProductId = 19, Comment = "This iss rating for product 19", Point = 6},
            new {RatingId = 5, RefProductIdProductId = 22, Comment = "This iss rating for product 22", Point = 9}
        );

    }

}
