using System.Data.Entity;

namespace SieveChat.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<ChatMsg> ChatMsg { get; set; }
    }
}