using TextCore.Helpers;


namespace TextCore.Interfaces
{
    public interface ITextFacade
    {
        ITextFactory GetTextFactory(InputTextTypes type);
    }
}
