using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CopaStefaniniBackEnd.Models.Entities;

namespace CopaStefaniniBackEnd.Repository
{
    public class CupContext : DbContext
    {
        public CupContext(DbContextOptions<CupContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        //public DbSet<Position> Positions { get; set; }
    }
}
