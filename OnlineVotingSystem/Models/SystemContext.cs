using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineVotingSystem.Models
{
    public class SystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Voting> Votings { get; set; }
        public DbSet<Voice> Voices { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(p => p.BirthDate).HasColumnType("datetime2").HasPrecision(0);

            modelBuilder.Entity<User>().HasKey(p => p.Id);
            modelBuilder.Entity<Role>().HasKey(p => p.Id);
            modelBuilder.Entity<Voting>().HasKey(p => p.Id);
            modelBuilder.Entity<Voice>().HasKey(p => p.Id);
            modelBuilder.Entity<Variant>().HasKey(p => p.Id);
            modelBuilder.Entity<Comment>().HasKey(p => p.Id);

            modelBuilder.Entity<User>().Property(p => p.Email).IsRequired();
            modelBuilder.Entity<User>().Property(p => p.BirthDate).IsRequired();
            modelBuilder.Entity<User>().Property(p => p.IsBlocked).IsRequired();

            modelBuilder.Entity<Role>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<Voting>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Voting>().Property(p => p.StartDate).IsRequired();
            modelBuilder.Entity<Voting>().Property(p => p.EndDate).IsRequired();
            modelBuilder.Entity<Voting>().Property(p => p.LastActivityUser).IsRequired();
            modelBuilder.Entity<Voting>().Property(p => p.LastActivityDate).IsRequired();
            modelBuilder.Entity<Voting>().Property(p => p.UserId).IsRequired();
            modelBuilder.Entity<Voting>().Property(p => p.State).IsRequired();
            
            modelBuilder.Entity<Voice>().Property(p => p.VariantId).IsRequired();

            modelBuilder.Entity<Variant>().Property(p => p.VotingId).IsRequired();
            modelBuilder.Entity<Variant>().Property(p => p.Text).IsRequired();

            modelBuilder.Entity<Comment>().Property(p => p.VotingId).IsRequired();
            modelBuilder.Entity<Comment>().Property(p => p.Text).IsRequired();
            modelBuilder.Entity<Comment>().Property(p => p.UserId).IsRequired();
            modelBuilder.Entity<Comment>().Property(p => p.Date).IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(p => p.Votings)
                .WithRequired(p => p.User);
            modelBuilder.Entity<User>()
                .HasMany(p => p.Voices)
                .WithRequired(p => p.User);

            modelBuilder.Entity<Voting>()
                .HasMany(p => p.Variants)
                .WithRequired(p => p.Voting)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Voting>()
               .HasMany(p => p.Comments)
               .WithRequired(p => p.Voting);
            modelBuilder.Entity<Variant>()
                .HasMany(p => p.Voices)
                .WithRequired(p => p.Variant);

            modelBuilder.Entity<User>()
                .HasMany(p => p.Roles)
                .WithMany(p => p.Users);

            base.OnModelCreating(modelBuilder);
        }
    }
}