using Microsoft.EntityFrameworkCore;
using TextInfrastructure.Models;


namespace TextInfrastructure
{
    public class TextContext : DbContext
    {
        public TextContext(DbContextOptions<TextContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TextContent> TextContents { get; set; }
    }
}
