using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestStoring.Entities
{
    public partial class PizzaBoxDBNickContext : DbContext
    {
        public PizzaBoxDBNickContext()
        {
        }

        public PizzaBoxDBNickContext(DbContextOptions<PizzaBoxDBNickContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:pizzaboxapp-nick.database.windows.net,1433;Initial Catalog=PizzaBoxDB-Nick;User ID=dev;Password=<password>");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasMany(a => a.Owners)
                .WithMany(o => o.Animals);



            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
