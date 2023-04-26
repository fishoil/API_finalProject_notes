using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using NotesAPI;

namespace NotesAPI.Models
{
    public class DBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DBContext(DbContextOptions<DBContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("NoteDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Note> Notes { get; set; } = null!;
    }
}

