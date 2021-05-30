using TextCore.DTO;
using TextCore.Exceptions;
using TextCore.Interfaces;
using TextCore.Repositories.Interfaces;


namespace TextCore.Commands
{
    public class GetTextCommand : IGetTextCommand
    {
        private readonly ITextRepository _textRepository;
        public GetTextCommand(ITextRepository textRepository)
        {
            _textRepository = textRepository;
        }

        public TextDto Execute(int id)
        {
            var text = _textRepository.GetById(id);

            if (text == null)
            {
                throw new EntityNotFoundException(id, typeof(TextDto));
            }

            return new TextDto { Text = text.Content, Id = text.Id };
        }
    }
}
