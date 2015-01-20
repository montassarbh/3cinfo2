using Gambling.Data.Configurations;
using Gambling.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data
{
    public class GamblingContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rat> Rats { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Race> Races { get; set; }

        public DbSet<Result> Results { get; set; }

        public GamblingContext()
            : base("Name=GamblingDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new RatConfiguration());
            modelBuilder.Configurations.Add(new RaceConfiguration());

            modelBuilder.Configurations.Add(new ResultConfiguration());
        }
    }
}
