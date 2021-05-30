using TextCore.DTO;


namespace TextCore.Interfaces
{
    public interface ITextFactory
    {
        WordCntDto ReadTextFromUserInput(UserInputDto text);
    }
}
