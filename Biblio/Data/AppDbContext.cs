using Biblio.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblio.Data
{
    //translator between model and database
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Provides a simple API surface for configuring a IMutableModel that defines
        //the shape of your entities, the relationships between them,
        //and how they map to the database.
        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {

            base.OnModelCreating(modelbuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
