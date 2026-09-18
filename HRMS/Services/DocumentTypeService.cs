using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class DocumentTypeService : IDocumentTypeRepository
    {
        private readonly HrmsDbContext _db;

        public DocumentTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<DocumentType>> GetDocumentTypes()
            => await _db.DocumentTypetbl.ToListAsync();

        public async Task<DocumentType?> GetDocumentTypeById(int documentTypeId)
            => await _db.DocumentTypetbl
                .FirstOrDefaultAsync(x => x.DocumentTypeId == documentTypeId);

        public async Task<DocumentType> AddDocumentType(DocumentType documentType)
        {
            _db.DocumentTypetbl.Add(documentType);
            await _db.SaveChangesAsync();
            return documentType;
        }

        public async Task<DocumentType?> UpdateDocumentType(
            DocumentType documentType)
        {
            var existing = await _db.DocumentTypetbl
                .FirstOrDefaultAsync(x =>
                    x.DocumentTypeId == documentType.DocumentTypeId);

            if (existing == null)
                return null;

            existing.DocumentTypeName = documentType.DocumentTypeName;
            existing.IsActive = documentType.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteDocumentType(int documentTypeId)
        {
            var documentType = await _db.DocumentTypetbl
                .FirstOrDefaultAsync(x =>
                    x.DocumentTypeId == documentTypeId);

            if (documentType == null)
                return false;

            _db.DocumentTypetbl.Remove(documentType);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
