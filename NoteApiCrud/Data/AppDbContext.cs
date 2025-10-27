using Microsoft.EntityFrameworkCore;
using NoteApiCrud.Models;

namespace NoteApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
