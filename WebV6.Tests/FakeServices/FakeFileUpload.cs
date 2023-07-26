using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webV6.Services.FileUploadService;

namespace WebV6.Tests.FakeServices
{
    public class FakeFileUpload : IFileUploadService
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment environment;

        //public FakeFileUpload(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        //{
        //    this.environment = environment;
        //}

        public async Task<string> UploadFileasync(IFormFile file)
        {
            var filePath = Path.Combine(environment.ContentRootPath, @"wwwroot\animal images", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return filePath;
        }
    }
}
