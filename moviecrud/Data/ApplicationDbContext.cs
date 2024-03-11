using Microsoft.EntityFrameworkCore;
using moviecrud.Models;

namespace moviecrud.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op) 
        { }

        public DbSet<Movie> Movies { get; set; }    
    }
}
