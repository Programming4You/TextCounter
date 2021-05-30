using TextCore.DTO;
using System.Collections.Generic;


namespace TextCore.Interfaces
{
    public interface IGetTextsCommand : IQueryCommand<List<WordCntDto>>
    {
    }
}
