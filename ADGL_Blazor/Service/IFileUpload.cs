using Microsoft.AspNetCore.Components.Forms;

namespace ADGL_Blazor.Service
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);
    }
}
