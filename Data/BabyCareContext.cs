using Baby_ShoppingOnline.Entity;
using Microsoft.EntityFrameworkCore;

namespace Baby_ShoppingOnline.Data;

public class BabyCareContext(DbContextOptions<BabyCareContext> options) : DbContext(options)
{
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Rating> Ratings => Set<Rating>();
    public DbSet<Account> Accounts => Set<Account>();

}
