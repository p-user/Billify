using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Billify.DAL.Models;

namespace Billify.DAL.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
             new IdentityRole
             {
                 Id = "1",
                 Name = "Admin",
                 NormalizedName= "ADMIN",
                 ConcurrencyStamp=null
             },
             new IdentityRole
             {
                 Id = "2",
                 Name = "Supervisor",
                 NormalizedName= "SUPERVISOR",
                 ConcurrencyStamp=null
             },
             new IdentityRole
             {
                 Id = "3",
                 Name = "Operator",
                 NormalizedName= "OPERATOR",
                 ConcurrencyStamp=null
             });
            modelBuilder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = "1",
                UserName = "Admin",
                Email= "admin@something.al",
                PasswordHash=GetSha256Hash("1234")
            });
            modelBuilder.Entity<IdentityUser>()
           .Ignore(c => c.AccessFailedCount)
           .Ignore(c => c.LockoutEnabled)
           .Ignore(c => c.TwoFactorEnabled)
           .Ignore(c => c.ConcurrencyStamp)
           .Ignore(c => c.LockoutEnd)
           .Ignore(c => c.EmailConfirmed)
           .Ignore(c => c.TwoFactorEnabled)
           .Ignore(c => c.LockoutEnd)
           .Ignore(c => c.AccessFailedCount)
           .Ignore(c => c.PhoneNumberConfirmed)
           .Ignore(c => c.NormalizedEmail);
            modelBuilder.Entity<IdentityUser>().ToTable("user_details");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("user_role");

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
             new IdentityUserRole<string>
             {
                 RoleId= "1",
                 UserId= "1",
             });

           modelBuilder.Entity<IdentityRole>().ToTable("role");
            modelBuilder.Ignore<IdentityUserToken<string>>();
            modelBuilder.Ignore<IdentityUserLogin<string>>();
            //modelBuilder.Ignore<IdentityUserClaim<string>>();
            //modelBuilder.Ignore<IdentityRoleClaim<string>>();
        }
        private string GetSha256Hash(string input)
        {
            using (var hashAlgorithm = SHA512.Create())
            {
                var byteValue = Encoding.UTF8.GetBytes(input);
                var byteHash = hashAlgorithm.ComputeHash(byteValue);
                return Convert.ToBase64String(byteHash);
            }
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Bill_Product> Bill_products { get; set; }
    }
}
