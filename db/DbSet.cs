namespace api_bd.db
{
    public static class DbInitializer
    {
        public static void Initialize(YourDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any() || context.Categories.Any())
            {
                return;
            }

            var products = new Product[]
            {
            new Product { Name = "Product 1", Description = "Description for Product 1", Price = 10},
            new Product { Name = "Product 2", Description = "Description for Product 2", Price = 19}
            };

            context.Products.AddRange(products);

            var categories = new Category[]
            {
            new Category { Name = "Category 1", Description = "Description for Category 1" },
            new Category { Name = "Category 2", Description = "Description for Category 2" }
            };

            context.Categories.AddRange(categories);

            context.SaveChanges();
        }
    }
}
