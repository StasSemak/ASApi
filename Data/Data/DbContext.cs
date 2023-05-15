using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class DbContext : IdentityDbContext<User>
    {
        public DbContext(DbContextOptions options) : base(options) { }
        public DbContext() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().HasOne(x => x.Role)
                                  .WithMany(x => x.Users)
                                  .HasForeignKey(x => x.RoleId)
                                  .HasPrincipalKey(x => x.Id)
                                  .IsRequired();
            builder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Entity<Category>().Property(x => x.Name)
                                      .IsRequired()
                                      .HasMaxLength(250);
            builder.Entity<Category>().Property(x => x.Image)
                                      .IsRequired()   
                                      .HasMaxLength(255);
            builder.Entity<Category>().Property(x => x.Description)
                                      .HasMaxLength(4000);
            builder.Entity<Category>().Property(x => x.IsDeleted)
                                      .HasDefaultValue(false);
            builder.Entity<Category>().Property(x => x.DateCreated)
                                      .HasDefaultValue(DateTime.UtcNow);
            

            builder.Entity<Role>().HasData(MockData.GetRoles());
            builder.Entity<User>().HasData(MockData.GetUsers());
            builder.Entity<Category>().HasData(MockData.GetCategories());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}