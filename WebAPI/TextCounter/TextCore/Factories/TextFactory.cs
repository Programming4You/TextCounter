using TextCore.DTO;
using TextCore.Interfaces;
using System;


namespace TextCore.Factories
{
    public abstract class TextFactory : ITextFactory
    {
        public virtual WordCntDto ReadTextFromUserInput(UserInputDto text)
        {
            return CountWords(text.Content);
        }

        private WordCntDto CountWords(string text)
        {
            var arrWords = text.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            return new WordCntDto(arrWords.Length, text);
        }
    }
}
