using Baby_ShoppingOnline.Data;
using Baby_ShoppingOnline.Entity;
using Baby_ShoppingOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace Baby_ShoppingOnline.Endpoints;

public static class BabyCareEndPoints
{
    const string GetBabyCareEndPoints = "GetBabyCare";

    private static readonly List<ProductDTO> productDTOs = new List<ProductDTO> 
    {
        new ProductDTO { ProductId = 1, ProductName = "1", RefCategoryId = 1, Description = "", Price = 10000, Image = ""}
    };

    public static RouteGroupBuilder MapBabyCareEndPoints(this WebApplication application)
    {
        var group = application.MapGroup("baby");
        group.MapGet("/", () => productDTOs);

        group.MapGet("/product/{id}", (int id, BabyCareContext dbContext) =>
        {
            Product product = dbContext.Products.Find(id);
            return product is null ? Results.NotFound() : Results.Ok(new ProductDTO {ProductId = product.ProductId, ProductName = product.ProductName, RefCategoryId = product.RefCategoryId.CategoryId, Description = product.Description, Price = product.Price, Image = product.Image});
        }).WithName(GetBabyCareEndPoints);

        group.MapPost("/", (ProductDTO newProduct) => {
            ProductDTO product = new ProductDTO {
                ProductId = productDTOs.Count + 1, ProductName = newProduct.ProductName, RefCategoryId = newProduct.RefCategoryId, Description = newProduct.Description, Price = newProduct.Price, Image = newProduct.Image
            };
            return Results.CreatedAtRoute(GetBabyCareEndPoints, new {id = product.ProductId});
        });
    }
}