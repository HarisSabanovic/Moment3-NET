using Microsoft.EntityFrameworkCore;
using Moment3.Models;

namespace Moment3.Data;

public class BookDbContext : DbContext {

    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) {

    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

}