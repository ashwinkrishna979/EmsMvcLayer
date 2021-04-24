using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmsEntities;

namespace EmsMvcLayer.Data
{
    public class EmsMvcLayerContext : IdentityDbContext<ApplicationUser>
    {
        public EmsMvcLayerContext(DbContextOptions<EmsMvcLayerContext> options)
            : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "RegulrUser",
                    NormalizedName = "REGULARUSER"
                }
                );
            base.OnModelCreating(builder);
        }
    }
}
