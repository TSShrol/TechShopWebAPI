using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Data
{
    public class TechShopDbContext:DbContext 
    {
        public TechShopDbContext(DbContextOptions<TechShopDbContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptions options) {
        //    options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=TexhShop; Integrated Security=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().HasMany(u => u.Orders)
            //                            .WithOne(o => o.User)
            //                            .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Category>().HasData(MockData.GetCategory());
            modelBuilder.Entity<Product>().HasData(MockData.GetProduct());
        }

        public DbSet<Category> Categories { get; set; }
        //public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
