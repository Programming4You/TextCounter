using Microsoft.AspNetCore.Mvc;
using TextCore.Interfaces;
using TextCore.ViewModels;


namespace TextApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : ControllerBase
    {
		[HttpPost]
		public IActionResult InsertNewText([FromServices] IAddTextCommand _command, [FromBody] TextViewModel textViewModel)
		{
			var result = _command.Execute(new TextCore.DTO.CreateTextDto(textViewModel.Content));

			if (result.Success)
			{
				return Ok(result.Data);
			}

			return StatusCode(result.StatusCode, result);
		}

		[HttpGet]
		public IActionResult GetDBTextData([FromServices] IGetTextsCommand _command)
		{
			return Ok(_command.Execute());
		}
	}
}
