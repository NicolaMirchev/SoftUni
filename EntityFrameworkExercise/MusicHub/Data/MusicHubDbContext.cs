namespace MusicHub.Data
{
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;

    public class MusicHubDbContext : DbContext
    {
        public MusicHubDbContext()
        {
        }

        public MusicHubDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Performer> Performers { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<SongPerformer> SongPerformers { get; set; }
        public DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Song>(entity =>
            {
                entity.HasMany(e => e.SongPerformers).WithOne(e => e.Song);            
            });

            builder.Entity<Performer>(entity => { 
            
                entity.HasMany(e => e.PerformerSongs).WithOne(e => e.Performer);    
            
            });

            builder.Entity<Writer>(entity =>
            {
                entity.HasMany(e => e.Songs).WithOne(e => e.Writer);
            });

            builder.Entity<Album>(entity => {

                entity.HasMany(e => e.Songs).WithOne(e => e.Album);

            });

            builder.Entity<Producer>(entity =>
            {
                entity.HasMany(e => e.Albums).WithOne(e => e.Producer);
            });

            builder.Entity<SongPerformer>(entity =>
            {
                entity.HasKey("SongId", "PerformerId");
            });
        }
    }
}
