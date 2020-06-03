using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using product_web_app.Models;

namespace product_web_app.Data
{
    public class ProductWebAppDbContext : DbContext
    {
        public ProductWebAppDbContext(DbContextOptions<ProductWebAppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set;}
    }
}