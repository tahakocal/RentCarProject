using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Halper.FileHalper
{
    public interface FileHelperManager
    {
        string Upload(IFormFile file, string root);
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
    }
}
