using Microsoft.EntityFrameworkCore;
using Noteapp.Models;
namespace Noteapp.Database
{
    class NoteAppContext : DbContext
    {
        public DbSet<NotesSet> Note { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Env.Connection_String);
        }
    }
}
