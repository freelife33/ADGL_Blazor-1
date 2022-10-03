using Microsoft.AspNetCore.Components.Forms;

namespace ADGL_Blazor.Service
{
    public class FileUpload : IFileUpload
    {

        private readonly IWebHostEnvironment _env;

        public FileUpload(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName=Guid.NewGuid().ToString()+fileInfo.Extension;
                var folderDir = $"{_env.WebRootPath}\\CourseImages";
                var path=Path.Combine(_env.WebRootPath,"CourseImages", fileName);

                var memoryStream= new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStream);

                if (!Directory.Exists(folderDir))
                {
                    Directory.CreateDirectory(folderDir);
                    
                }
                await using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memoryStream.WriteTo(fs);
                }
                var fullPath = $"CourseImages/{fileName}";
                return fullPath;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
