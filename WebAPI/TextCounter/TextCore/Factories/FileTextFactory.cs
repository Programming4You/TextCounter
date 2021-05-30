using TextCore.DTO;
using System;
using System.IO;
using System.Text;


namespace TextCore.Factories
{
    public class FileTextFactory : TextFactory
    {
		public override WordCntDto ReadTextFromUserInput(UserInputDto dto)
		{
            var bytes = Convert.FromBase64String(dto.Content);

            var contents = new StreamReader(new MemoryStream(bytes), Encoding.ASCII).ReadToEnd();
			return base.ReadTextFromUserInput(new UserInputDto { Content = contents });
		}
	}
}
