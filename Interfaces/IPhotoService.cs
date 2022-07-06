using CloudinaryDotNet.Actions; // Tem que adicionar esse pacote através do nuget

namespace RunGroopWebApp.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
} 