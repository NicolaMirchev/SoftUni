using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCodeFirstApproach.Models
{
    internal class PeopleConnectionContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<FriendRelation> FriendRelations { get; set; } = null!;

        public DbSet<Activity> Activities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=PeopleConnections;User Id=sa;Password=routesetit2022");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
                {
                    entity.Property(e => e.PersonId).ValueGeneratedOnAdd();
                    entity.HasMany(e => e.Activity);

                    entity.HasOne(e => e.FriendsRelations).WithMany(e => e.Friends).HasForeignKey(e => e.PersonId);
                });

            modelBuilder.Entity<FriendRelation>(entity =>
            {
                entity.HasKey(e => e.PersonId);


                entity.HasMany(e => e.Friends).WithOne(e => e.FriendsRelations).OnDelete(DeleteBehavior.ClientSetNull);
            });
        }

    }
}
