using TextCore.Helpers;
using TextCore.Interfaces;


namespace TextCore.Factories
{
    public class TextFacade : ITextFacade
    {
        public ITextFactory GetTextFactory(InputTextTypes type)
        {
			switch (type)
			{
				case InputTextTypes.DatabaseInput:
					return new DBTextFactory();
				case InputTextTypes.FileInput:
					return new FileTextFactory();
				default:
					return new UserInputTextFactory();
			}
		}
    }
}
