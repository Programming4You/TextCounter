using Microsoft.AspNetCore.Mvc;
using TextCore.Interfaces;
using TextCore.ViewModels;
using TextCore.Helpers;
using TextCore.Exceptions;


namespace TextApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileInputController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetFileInputWordCount([FromServices] IGetTextFromFileCommand _command, [FromBody] FileUploadViewModel file)
        {
            if (!Base64Validation.IsBase64String(file.FileInBase64String)) 
            {
                throw new FormatException(file.FileInBase64String);
            }

            return Ok(_command.Execute(new TextCore.DTO.FileUploadDto(file.FileInBase64String)));
        }
    }
}
