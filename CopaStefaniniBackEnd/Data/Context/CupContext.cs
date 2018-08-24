using Microsoft.EntityFrameworkCore;
using CopaStefaniniBackEnd.Models.Entities;

namespace CopaStefaniniBackEnd.Repository
{
    public class CupContext : DbContext
    {
        public CupContext(DbContextOptions<CupContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }        
    }
}
