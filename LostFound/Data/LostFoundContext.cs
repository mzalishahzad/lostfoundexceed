using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LostFound.Entities;

namespace LostFound.Data
{
    public class LostFoundContext : DbContext
    {
        public LostFoundContext (DbContextOptions<LostFoundContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; } = default!;
    }
}
