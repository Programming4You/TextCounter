using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TextInfrastructure
{
    public class TextContextFactory : IDesignTimeDbContextFactory<TextContext>
    {
        public TextContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TextContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-K3PNK4G\\SQLEXPRESS; Database=OrionDB; Trusted_Connection=True; MultipleActiveResultSets=True;");

            return new TextContext(optionsBuilder.Options);
        }
    }
}
