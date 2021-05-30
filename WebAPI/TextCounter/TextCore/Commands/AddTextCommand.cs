using Microsoft.AspNetCore.Http;
using TextCore.DTO;
using TextCore.Helpers;
using TextCore.Interfaces;
using TextCore.Repositories.Interfaces;
using TextCore.ViewModels;


namespace TextCore.Commands
{
    public class AddTextCommand : IAddTextCommand
    {
        private readonly ITextRepository _textRepository;
        private readonly ITextFacade _textFacade;

        public AddTextCommand(ITextRepository textRepository, ITextFacade textFacade)
        {
            _textRepository = textRepository;
            _textFacade = textFacade;
        }

        public OperationResult<WordCntDto> Execute(CreateTextDto dto)
        {
            if (dto == null)
            {
                return new OperationResult<WordCntDto>
                {
                    Message = "Text can not be read. Please try later...",
                    Success = false,
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }

            _textRepository.Add(new TextInfrastructure.Models.TextContent { Content = dto.Text });
            var databaseFactory = _textFacade.GetTextFactory(InputTextTypes.DatabaseInput);
            var result = databaseFactory.ReadTextFromUserInput(new UserInputDto { Content = dto?.Text });

            return new OperationResult<WordCntDto>
            {
                Data = result,
                Success = true
            };
        }
    }
}
