using Microsoft.EntityFrameworkCore;
using RPG.Data.Models;

namespace RPG.Data
{
    public class RPGContext : DbContext
    {
        public RPGContext() { }

        public RPGContext(DbContextOptions options)
            : base(options) { }



        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }
    }
}
