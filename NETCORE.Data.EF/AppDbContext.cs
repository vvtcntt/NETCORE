using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NETCORE.Data.EF.Configruations;
using NETCORE.Data.EF.Extentions;
using NETCORE.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.EF
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Language> Languages { set; get; }
        public DbSet<Announcement> Announcements { set; get; }
        public DbSet<AnnouncementUser> AnnouncementUsers { set; get; }
        public DbSet<AppRole> AppRoles { set; get; }
        public DbSet<AppUser> AppUsers { set; get; }
        public DbSet<Bill> Bills { set; get; }
        public DbSet<BillDetail> BillDetails { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<Config> Configs { set; get; }
        public DbSet<Contact> Contacts { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductColor> ProductColors { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
        public DbSet<ProductSize> ProductSizes { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Size> Sizes { set; get; }
        public DbSet<Function> Functions { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Permission> Permissions { set; get; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config


            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });

            #endregion Identity Config
            builder.AddConfiguration(new TagConfigguration());
            builder.AddConfiguration(new SystemConfigConfiguration());
            builder.AddConfiguration(new AnnouncementConfiguration());
            builder.AddConfiguration(new FunctionConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
