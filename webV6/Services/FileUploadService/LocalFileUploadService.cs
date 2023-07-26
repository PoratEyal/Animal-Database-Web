namespace webV6.Services.FileUploadService
{
    public class LocalFileUploadService : IFileUploadService
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        public LocalFileUploadService(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public async Task<string> UploadFileasync(IFormFile file)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\animal images", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create); 
            await file.CopyToAsync(fileStream);
            return filePath;
        }
    }
}
