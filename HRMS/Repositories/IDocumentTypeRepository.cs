using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IDocumentTypeRepository
    {
        Task<List<DocumentType>> GetDocumentTypes();
        Task<DocumentType?> GetDocumentTypeById(int documentTypeId);
        Task<DocumentType> AddDocumentType(DocumentType documentType);
        Task<DocumentType?> UpdateDocumentType(DocumentType documentType);
        Task<bool> DeleteDocumentType(int documentTypeId);
    }
}
