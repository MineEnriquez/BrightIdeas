using Microsoft.EntityFrameworkCore;
namespace BrightIdeas.Models
{
    public class BrightIdeasContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public BrightIdeasContext(DbContextOptions options) : base(options) { 
	                          
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments {get; set;}
        
    }
}