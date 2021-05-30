using TextCore.Repositories.Interfaces;
using TextInfrastructure;
using TextInfrastructure.Models;


namespace TextCore.Repositories
{
    public class TextRepository : BaseRepository<TextContent>, ITextRepository
    {
        public TextRepository(TextContext context) : base(context)
        {

        }
    }
}
