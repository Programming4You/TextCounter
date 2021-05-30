using TextCore.DTO;


namespace TextCore.Interfaces
{
    public interface IGetUserInputCommand : IActionCommand<UserInputDto, WordCntDto>
    {
    }
}
