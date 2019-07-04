using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntityConfig;
using System;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext(DbContextOptions<ProjetoModeloContext> options)
            : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(new ClientMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateRegister") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateRegister").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateRegister").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
