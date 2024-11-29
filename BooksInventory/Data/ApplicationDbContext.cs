using Microsoft.EntityFrameworkCore;
using BooksInventory.Models;

namespace BooksInventory.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<BookItem> BookItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BooksDB;Trusted_Connection=True;");
        }
    }
}
