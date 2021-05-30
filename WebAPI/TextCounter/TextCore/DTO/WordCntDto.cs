

namespace TextCore.DTO
{
    public class WordCntDto : BaseDto
    {
        public WordCntDto(int count, string text)
        {
            Count = count;
            Text = text;
        }

        public int Count { get; set; }
        public string Text { get; set; }
    }
}
