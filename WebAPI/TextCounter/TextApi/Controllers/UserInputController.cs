using Microsoft.AspNetCore.Mvc;
using TextCore.Interfaces;
using TextCore.ViewModels;


namespace TextApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInputController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetUserInputTextCount([FromServices] IGetUserInputCommand _command, [FromBody] TextViewModel textViewModel)
        {
            return Ok(_command.Execute(new TextCore.DTO.UserInputDto { Content = textViewModel.Content }));
        }
    }
}
