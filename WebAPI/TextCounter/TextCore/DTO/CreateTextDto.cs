

namespace TextCore.DTO
{
    public class CreateTextDto
    {
        public CreateTextDto(string inputTxt)
        {
            Text = inputTxt;
        }

        public string Text { get; set; }
    }
}
