using TextCore.DTO;


namespace TextCore.Interfaces
{
    public interface IGetTextCommand : IActionCommand<int, TextDto>
    {
    }
}
