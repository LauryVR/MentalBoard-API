using MentalBoard_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentalBoard_API.Contexts
{
    public class MentalBoardContext : IdentityDbContext<AppUser, AppRole, int, AppUserClaim, AppUserRole, AppUserLogin, AppClaim, AppUserToken>
    {
        public MentalBoardContext(DbContextOptions<MentalBoardContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<AppUser>().ToTable("AspNetUsers");
            modelBuilder.Entity<AppRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<AppUserClaim>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<AppUserLogin>().ToTable("AspNetUserLogins");
            modelBuilder.Entity<AppUserRole>().ToTable("AspNetUserRoles");
            modelBuilder.Entity<AppUserToken>().ToTable("AspNetUserTokens");
        }

        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserClaim> AppUserClaims { get; set; }
        public DbSet<AppUserLogin> AppUserLogins { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<AppUserToken> AppUserTokens { get; set; }
    }
}
