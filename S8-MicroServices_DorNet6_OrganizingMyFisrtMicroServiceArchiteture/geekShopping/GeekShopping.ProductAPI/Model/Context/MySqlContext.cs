using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {

        public MySqlContext()
        {
                
        }
        public MySqlContext(DbContextOptions<MySqlContext>options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Star Wars Mission Fleet Han Solo Nave Milennium Falcon",
                Price = new decimal(359.99),
                Description = "NAVE DO HAN SOLO MILENNIUM FALCON",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true",
                CategoryName = "Action Figure"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Comemorativa FRIENDS",
                Price = new decimal(69.9),
                Description = "Camista de comemoração de 30 anos do seriado FRIENDS",
                ImageURL = "https://github.com/marcelocardoso74/curso-microservices-dotnet6/blob/main/Imagens/camisetafriends.png?raw=true",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Capacete Darth Vader Star Wars Black Series",
                Price = new decimal(999.99),
                Description = "capacete comemorativo Darth Vader",
                ImageURL = "https://github.com/marcelocardoso74/curso-microservices-dotnet6/blob/main/Imagens/capacetedarthvader.jpg?raw=true",
                CategoryName = "Action Figure"
            });
        }

    }
}
