using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.Identity
{
    public class NackowskisDBContext : IdentityDbContext<AppUser>
    {
        public NackowskisDBContext(DbContextOptions<NackowskisDBContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "Admin".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Regular", NormalizedName = "Regular".ToUpper() });
        }
    }
}
