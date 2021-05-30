using TextCore.DTO;
using TextCore.Helpers;
using TextCore.Interfaces;
using TextCore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace TextCore.Commands
{
    public class GetTexstsCommand : IGetTextsCommand
    {
        private readonly ITextRepository _textRepository;
        private readonly ITextFacade _textFacade;
        private readonly ITextFactory _databaseTextFactory;

        public GetTexstsCommand(ITextRepository textRepository, ITextFacade textFacade)
        {
            _textRepository = textRepository;
            _textFacade = textFacade;
            _databaseTextFactory = _textFacade.GetTextFactory(InputTextTypes.DatabaseInput);
        }
         
        public List<WordCntDto> Execute()
        {
            var texts = _textRepository.GetAll();

            return texts?.Select(x => new WordCntDto(_databaseTextFactory.ReadTextFromUserInput(new UserInputDto { Content = x.Content }).Count, x.Content)).ToList();
        }
    }
}
