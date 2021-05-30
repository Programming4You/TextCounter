

namespace TextCore.DTO
{
    public class FileUploadDto
    {
        public FileUploadDto(string fileBase64)
        {
            FileBase64 = fileBase64;
        }

        public string FileBase64 { get; set; }
    }
}
