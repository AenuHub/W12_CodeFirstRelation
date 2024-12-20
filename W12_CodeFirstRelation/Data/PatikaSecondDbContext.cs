using Microsoft.EntityFrameworkCore;

namespace W12_CodeFirstRelation.Data;

public class PatikaSecondDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // hardcoded connection string is used only for testing purposes
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PatikaCodeFirstDb2;Username=postgres;Password=6330");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>()
            .HasOne(u => u.User)
            .WithMany(p => p.Posts)
            .HasForeignKey(p => p.UserId);
        
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "Eren", Email = "noob@gmail.com" },
            new User { Id = 2, Username = "Mikasa", Email = "easypeesy@hotmail.com" },
            new User { Id = 3, Username = "Armin", Email = "armin@yahoo.com" }
        );

        modelBuilder.Entity<Post>().HasData(
            new Post { Id = 1, Title = "First Post", Content = "First Post Content", UserId = 1 },
            new Post { Id = 2, Title = "Second Post", Content = "Second Post Content", UserId = 2 },
            new Post { Id = 3, Title = "Third Post", Content = "Third Post Content", UserId = 3 },
            new Post { Id = 4, Title = "Fourth Post", Content = "Fourth Post Content", UserId = 1 },
            new Post { Id = 5, Title = "Fifth Post", Content = "Fifth Post Content", UserId = 2 }
        );
    }
}