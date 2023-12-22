using BetterTogetherBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace BetterTogetherBackend.Database;

public class BtContext(DbContextOptions<BtContext> options) : DbContext(options)
{
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Media> Medias { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Watched> Watched { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureUserEntity(ref modelBuilder);
        ConfigureMediaEntity(ref modelBuilder);
        
        base.OnModelCreating(modelBuilder);
    }

    private void ConfigureUserEntity(ref ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(user => user.Comments)
            .WithOne(comment => comment.User);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Friends)
            .WithMany(user => user.Friends);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Favourites)
            .WithMany(media => media.FavouritesBy);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Planned)
            .WithMany(media => media.PlannedBy);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Watched)
            .WithOne(watched => watched.User);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Ratings)
            .WithOne(rating => rating.User);

        modelBuilder.Entity<User>()
            .HasMany(user => user.Comments)
            .WithOne(comment => comment.User);
    }

    private void ConfigureMediaEntity(ref ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Media>()
            .HasMany(media => media.Genres)
            .WithMany(genre => genre.Medias);

        modelBuilder.Entity<Media>()
            .HasMany(media => media.Watched)
            .WithOne(watched => watched.Media);

        modelBuilder.Entity<Media>()
            .HasMany(media => media.Ratings)
            .WithOne(rating => rating.Media);

        modelBuilder.Entity<Media>()
            .HasMany(media => media.Comments)
            .WithOne(comment => comment.Media);
    }
}