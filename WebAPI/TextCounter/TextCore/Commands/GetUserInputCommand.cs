using TextCore.DTO;
using TextCore.Helpers;
using TextCore.Interfaces;


namespace TextCore.Commands
{
    public class GetUserInputCommand : IGetUserInputCommand
    {
        private readonly ITextFacade _textFacade;
        public GetUserInputCommand(ITextFacade textFacade)
        {
            _textFacade = textFacade;
        }

        public WordCntDto Execute(UserInputDto dto)
        {
            var _userInputFactory = _textFacade.GetTextFactory(InputTextTypes.UserInput);
            return _userInputFactory.ReadTextFromUserInput(dto);
        }
    }
}
