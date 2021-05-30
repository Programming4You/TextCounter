using TextCore.DTO;


namespace TextCore.Interfaces
{
    public interface IGetTextFromFileCommand : IActionCommand<FileUploadDto, WordCntDto>
    {
    }
}
