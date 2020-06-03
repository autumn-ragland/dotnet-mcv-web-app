using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace product_web_app.Data
{
    public class ProductWebAppDbContextFactory : IDesignTimeDbContextFactory<ProductWebAppDbContext>
    {
        public ProductWebAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductWebAppDbContext>();
            optionsBuilder.UseSqlite("Data Source=app.db");
            return new ProductWebAppDbContext(optionsBuilder.Options);
        }
    }
}