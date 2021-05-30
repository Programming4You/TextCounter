using TextCore.DTO;
using TextCore.ViewModels;


namespace TextCore.Interfaces
{
    public interface IAddTextCommand : IActionCommand<CreateTextDto, OperationResult<WordCntDto>>
    {
    }
}
