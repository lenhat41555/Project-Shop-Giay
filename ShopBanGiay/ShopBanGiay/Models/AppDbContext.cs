using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBanGiay.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Product { set; get; }
        public DbSet<Category> categories { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Giay da" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Giay the thao" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Giay co" });

            modelBuilder.Entity<Product>().HasData(new Product


            {
                Id = 1,
                Name = "giay co",
                Price = 6000.000,
                Despition = "",
                Brand = "Dior",
                Color = "trắng",
                Amount = 1,
                CategoryId = 3,

            });
            modelBuilder.Entity<Product>().HasData(new Product


            {
                Id = 2,
                Name = "the thao",
                Price = 5000.000,
                Despition = "",
                Brand = "ev",
                Color = "đen",
                Amount = 1,
                CategoryId = 2,

            });
            modelBuilder.Entity<Product>().HasData(new Product


            {
                Id = 3,
                Name = "giay da",
                Price = 60000.000,
                Despition = "",
                Brand = "Dior",
                Color = "cam",
                Amount = 1,
                CategoryId = 1,

            });





        }
    }
}
    
