using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options)
                   : base(options)
        {
        }

        public virtual DbSet<Sample.Models.User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Method intentionally left empty.
        }
    }
}
