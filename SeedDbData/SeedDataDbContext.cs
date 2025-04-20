using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDbData
{
    public class SeedDataDbContext : DbContext
    {
        public SeedDataDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<HockeyPlayer> HockeyPlayers { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
    }
}
