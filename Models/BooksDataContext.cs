using Microsoft.EntityFrameworkCore;
public class BooksDataContext : DbContext
{

    public BooksDataContext(DbContextOptions opt) : base(opt)
    {

    }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "Walden", Author = "Thoreau" },
            new Book { Id = 2, Title = "Nature", Author = "Emerson" }

        );
    }
}