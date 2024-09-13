using db_api.Domain.Entities.Cmi;
using db_api.Domain.Entities.Lands;
using db_api.Domain.Entities.Playerpoints;
using db_api.Domain.Entities.Reputation;
using db_api_DAL.Configuration;
using Microsoft.EntityFrameworkCore;
using static db_api_DAL.Configuration.LandsPlayersConfiguration;

namespace db_api_DAL
{
    public class DbCmiContext : DbContext 
    {
        public DbCmiContext(DbContextOptions<DbCmiContext> options) : base(options)
        {
        }

        public DbSet<CmiUsers> CmiUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CmiUserConfiguration());
        }

    }


    public class DbReputationContext : DbContext
    {
        public DbReputationContext(DbContextOptions<DbReputationContext> options) : base(options)
        {
        }

        public DbSet<Reputation> Reputation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReputationConfiguration());
        }

    }


    public class DbPlayerpointsContext : DbContext
    {
        public DbPlayerpointsContext(DbContextOptions<DbPlayerpointsContext> options) : base(options)
        {
        }

        public DbSet<PlayerpointsPoints> PlayerpointsPoints { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerpointsPointsConfiguration());
        }

    }


    public class DbLandsContext : DbContext
    {
        public DbLandsContext(DbContextOptions<DbLandsContext> options) : base(options)
        {
        }
        public DbSet<LandsLands> LandsLands { get; set; }


        public DbSet<LandsPlayers> LandsPlayers { get; set; }
        public DbSet<LandsServers> LandsServers { get; set; }
        public DbSet<LandsWorlds> LandsWorlds { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LandsLandsConfiguration());
            modelBuilder.ApplyConfiguration(new LandsPlayersConfiguration());
            modelBuilder.ApplyConfiguration(new LandsServersConfiguration());
            modelBuilder.ApplyConfiguration(new LandsWorldsConfiguration());
        }

    }


}
