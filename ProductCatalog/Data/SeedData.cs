using ProductCatalog.Models;

namespace ProductCatalog.Data;

public static class SeedData
{
    public static void Initialize(ApplicationDbContext context)
    {
        // Check if database already has data
        if (context.Products.Any())
        {
            return;
        }

        var products = new Product[]
        {
            new Product
            {
                Name = "Laptop HP Pavilion",
                Description = "15.6 inch display, Intel Core i5, 8GB RAM, 256GB SSD",
                Category = "Electronics",
                Price = 699.99m,
                Stock = 15,
                CreatedDate = DateTime.Now.AddDays(-30)
            },
            new Product
            {
                Name = "Wireless Mouse Logitech",
                Description = "Ergonomic wireless mouse with USB receiver",
                Category = "Electronics",
                Price = 24.99m,
                Stock = 50,
                CreatedDate = DateTime.Now.AddDays(-25)
            },
            new Product
            {
                Name = "Office Chair Pro",
                Description = "Ergonomic office chair with lumbar support",
                Category = "Furniture",
                Price = 199.99m,
                Stock = 20,
                CreatedDate = DateTime.Now.AddDays(-20)
            },
            new Product
            {
                Name = "Standing Desk Adjustable",
                Description = "Electric height-adjustable standing desk, 60x30 inches",
                Category = "Furniture",
                Price = 449.99m,
                Stock = 8,
                CreatedDate = DateTime.Now.AddDays(-18)
            },
            new Product
            {
                Name = "Mechanical Keyboard RGB",
                Description = "Gaming mechanical keyboard with RGB backlighting",
                Category = "Electronics",
                Price = 89.99m,
                Stock = 30,
                CreatedDate = DateTime.Now.AddDays(-15)
            },
            new Product
            {
                Name = "USB-C Hub 7-in-1",
                Description = "Multi-port USB-C hub with HDMI, USB 3.0, and card reader",
                Category = "Electronics",
                Price = 39.99m,
                Stock = 45,
                CreatedDate = DateTime.Now.AddDays(-12)
            },
            new Product
            {
                Name = "Monitor 27 inch 4K",
                Description = "27 inch 4K UHD monitor with HDR support",
                Category = "Electronics",
                Price = 399.99m,
                Stock = 12,
                CreatedDate = DateTime.Now.AddDays(-10)
            },
            new Product
            {
                Name = "Desk Lamp LED",
                Description = "Adjustable LED desk lamp with touch controls",
                Category = "Furniture",
                Price = 34.99m,
                Stock = 25,
                CreatedDate = DateTime.Now.AddDays(-8)
            },
            new Product
            {
                Name = "Webcam Full HD 1080p",
                Description = "Full HD webcam with auto-focus and built-in microphone",
                Category = "Electronics",
                Price = 59.99m,
                Stock = 18,
                CreatedDate = DateTime.Now.AddDays(-5)
            },
            new Product
            {
                Name = "Noise Cancelling Headphones",
                Description = "Over-ear headphones with active noise cancellation",
                Category = "Electronics",
                Price = 149.99m,
                Stock = 22,
                CreatedDate = DateTime.Now.AddDays(-2),
                IsActive = false // Example of a soft-deleted product
            }
        };

        context.Products.AddRange(products);
        context.SaveChanges();
    }
}

