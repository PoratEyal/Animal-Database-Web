namespace webV6.Services.FileUploadService
{
    public interface IFileUploadService
    {
        Task<string> UploadFileasync(IFormFile file);
    }
}
