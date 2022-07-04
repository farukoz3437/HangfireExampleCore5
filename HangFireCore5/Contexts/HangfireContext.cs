using HangFireCore5.Entities;
using Microsoft.EntityFrameworkCore;

namespace HangFireCore5.Contexts
{
    public class HangfireContext : DbContext
    {
        public HangfireContext(DbContextOptions<HangfireContext> options) : base(options)
        {

        }
        public virtual DbSet<Number> Numbers { get; set; }
    }
}
