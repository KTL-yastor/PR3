using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Symulator.Models;

namespace Symulator.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Symulator.Models.Symbol> Symbol { get; set; } = default!;
    }
}
