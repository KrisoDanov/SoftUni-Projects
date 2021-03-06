
using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }
        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FootballSystem;IntegratedSecurity=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(t => t.TeamId);

                entity.Property(t => t.Name).
                IsRequired(true).
                IsUnicode(true)
                .HasMaxLength(50);

                entity.Property(t => t.LogoUrl).
               IsRequired(true).
               IsUnicode(false);

                entity.Property(t => t.Initials).
                IsRequired(true).
                IsUnicode(true)
                .HasMaxLength(5);

                entity.
                HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.PrimaryKitTeams)
                .HasForeignKey(t => t.PrimaryKitColorId);

                entity.
               HasOne(t => t.SecondaryKitColor)
               .WithMany(c => c.SecondaryKitTEam)
               .HasForeignKey(t => t.SecondaryKitColorId);

                entity.HasOne(t => t.Town)
                .WithMany(to => to.Teams)
                .HasForeignKey(t => t.TownId);
            });


            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(c => c.ColorId);

                entity.Property(t => t.Name).
               IsRequired(true).
               IsUnicode(true)
               .HasMaxLength(50);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasKey(t => t.TownId);

                entity.Property(t => t.Name).
               IsRequired(true).
               IsUnicode(true)
               .HasMaxLength(50);

                entity.HasOne(t => t.Country)
                .WithMany(t => t.Towns)
                .HasForeignKey(t => t.CountryId);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(c => c.CountryId);

                entity.Property(c => c.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(40);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(p => p.PlayerId);

                entity.Property(p => p.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(40);

                entity.HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId);

                entity.HasOne(p => p.Position)
                .WithMany(po => po.Players)
                .HasForeignKey(p => p.PostionId);
            });
            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(p => p.PostionId);

                entity.Property(p => p.Name)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(40);
            });
            modelBuilder.Entity<PlayerStatistic>(entity =>
            {
                entity.HasKey(ps => new { ps.PlayerId, ps.GameId });

                entity.HasOne(p => p.Player)
             .WithMany(po => po.PlayerStatistics)
             .HasForeignKey(p => p.PlayerId);

                entity.HasOne(p => p.Game)
             .WithMany(po => po.PlayerStatistics)
             .HasForeignKey(p => p.GameId);

            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(g => g.GameId);


                entity.Property(g => g.Result)
                .IsRequired(false)
                .IsUnicode(false)
                .HasMaxLength(10);

                entity.HasOne(g => g.HomeTeam)
                .WithMany(g => g.HomeGames)
                .HasForeignKey(g => g.HomeTeamId);

                entity.HasOne(g => g.AwayTeam)
                .WithMany(g => g.AwayGames)
                .HasForeignKey(g => g.AwayTeamId);

            });

            modelBuilder.Entity<Bet>(entity =>
            {
                entity.HasKey(b => b.BetId);

                entity.HasOne(b => b.User)
                .WithMany(b => b.Bets)
                .HasForeignKey(b => b.UserId);

                entity.HasOne(b => b.Game)
                .WithMany(b => Bets)
                .HasForeignKey(b => b.GameId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.UserId);

                entity.Property(u => u.Username)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(20);

                entity.Property(u => u.Password)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(20);

                entity.Property(u => u.Email)
                .IsRequired(true)
                .IsUnicode(true)
                .HasMaxLength(20);

                entity.Property(u => u.Name)
                .IsRequired(false)
                .IsUnicode(true)
                .HasMaxLength(20);
            });
        }
    }
}
