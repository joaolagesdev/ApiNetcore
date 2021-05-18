using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ItemsSolicitationEntity> ItemsSolicitation { get; set; }
        public DbSet<SolicitationEntity> Solicitation { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductEntity>(new ProductMap().Configure);
            modelBuilder.Entity<ItemsSolicitationEntity>(new ItemsSolicitationMap().Configure);
            modelBuilder.Entity<SolicitationEntity>(new SolicitationMap().Configure);
            modelBuilder.Entity<ItemsSolicitationEntity>().HasKey(pk => new { pk.ProductId });
            modelBuilder.Entity<ItemsSolicitationEntity>().HasKey(pk => new { pk.ItemsSolicitationId });
        }
    }
}
