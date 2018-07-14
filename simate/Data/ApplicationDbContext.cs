using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace simate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUser>().ToTable("T_Users");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityRole>().ToTable("T_Roles");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>>().ToTable("T_RoleClaims");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserClaim<string>>().ToTable("T_UserClaims");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserLogin<string>>().ToTable("T_UserLogins");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>().ToTable("T_UserRoles");
            builder.Entity<Microsoft.AspNetCore.Identity.IdentityUserToken<string>>().ToTable("T_UserTokens");
        }
    }
}
