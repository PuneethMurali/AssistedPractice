using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _06DailyAssessment.Models
{
    public partial class PlayersDbContext : DbContext
    {
        public PlayersDbContext()
        {
        }

        public PlayersDbContext(DbContextOptions<PlayersDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("server= PUNEETH;database= PlayersDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.PlayerId)
                    .ValueGeneratedNever()
                    .HasColumnName("Player_id");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.JerseyNumber).HasColumnName("jerseyNumber");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Team).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
