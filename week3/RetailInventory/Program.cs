using System.ComponentModel;
using RetailInventory.Models;
using RetailInventory.Data;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        var electronics = new Category { Name = "Electronics" };
        var groceries = new Category { Name = "Groceries" };

        await context.Categories.AddRangeAsync(electronics, groceries);

        var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
        var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

        await context.Products.AddRangeAsync(product1, product2);
        await context.SaveChangesAsync();

        Console.WriteLine("Initial data inserted successfully!");

        var products = await context.Products.ToListAsync();
        Console.WriteLine("All Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

 
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"\nFound by ID 1: {product?.Name}");

        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 5000);
        Console.WriteLine($"\nExpensive Product: {expensive?.Name}");
    }
}
