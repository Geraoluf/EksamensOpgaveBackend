using EksamensOpgaveBackend.Models;
using Microsoft.EntityFrameworkCore;


namespace EksamensOpgaveBackend.Data
{
    public class ConnectDbContext : DbContext
    {

        public ConnectDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<ProductModel> productModels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductModel>().HasData
            (new ProductModel
            {
                Id = 1,
                Name = "værktøj1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 20,
                ImageUrl = "https://placehold.co/600x400",
                YearOfProduction = 2023
            },

            new ProductModel
            {
                Id = 2,
                Name = "værktøj2",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 30,
                ImageUrl = "https://placehold.co/600x401",
                YearOfProduction = 2023

            },

            new ProductModel
            {
                Id = 3,
                Name = "værktøj3",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 30,
                ImageUrl = "https://placehold.co/600x401",
                YearOfProduction = 2023

            });
        }
    }    
}
