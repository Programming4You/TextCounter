using TextCore.DTO;
using TextCore.Helpers;
using TextCore.Interfaces;


namespace TextCore.Commands
{
    public class GetTextFromFileCommand : IGetTextFromFileCommand
    {
        private readonly ITextFacade _textFacade;
        public GetTextFromFileCommand(ITextFacade textFacade)
        {
            _textFacade = textFacade;
        }

        public WordCntDto Execute(FileUploadDto dto)
        {
            var fileInputFactory = _textFacade.GetTextFactory(InputTextTypes.FileInput);
            return fileInputFactory.ReadTextFromUserInput(new UserInputDto { Content = dto.FileBase64 });
        }
    }
}
