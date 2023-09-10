using Microservice.Products.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Microservice.Products.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options) { }

        public DbSet<Games> Games { get; set; }

        public DbSet<Developers> Developers { get; set; }
        public DbSet<Ganres> Ganres { get; set; }
        public DbSet<Platforms> Platforms { get; set; }
        public DbSet<Shares> Shares { get; set; }
        public DbSet<GamesKeys> GamesKeys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>().HasData(new Predefineds.PredefinedGames()._gamesList);
            modelBuilder.Entity<Developers>().HasData(new Predefineds.PredefinedDevelopers()._developersList);
            modelBuilder.Entity<Ganres>().HasData(new Predefineds.PredefinedGanres()._ganresList);
            modelBuilder.Entity<Platforms>().HasData(new Predefineds.PredefinedPlatforms()._platformsList);
            modelBuilder.Entity<Shares>().HasData(new Predefineds.PredefinedShares()._gamesList);
            modelBuilder.Entity<GamesKeys>().HasData(new Predefineds.PredefinedGamesKeys()._gamesKeysList);
        }
    }
}
