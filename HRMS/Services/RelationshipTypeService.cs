using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class RelationshipTypeService : IRelationshipTypeRepository
    {
        private readonly HrmsDbContext _db;

        public RelationshipTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<RelationshipType>> GetRelationshipTypes()
            => await _db.RelationshipTypetbl.ToListAsync();

        public async Task<RelationshipType?> GetRelationshipTypeById(
            int relationshipTypeId)
            => await _db.RelationshipTypetbl
                .FirstOrDefaultAsync(x =>
                    x.RelationshipTypeId == relationshipTypeId);

        public async Task<RelationshipType> AddRelationshipType(
            RelationshipType relationshipType)
        {
            _db.RelationshipTypetbl.Add(relationshipType);
            await _db.SaveChangesAsync();
            return relationshipType;
        }

        public async Task<RelationshipType?> UpdateRelationshipType(
            RelationshipType relationshipType)
        {
            var existing = await _db.RelationshipTypetbl
                .FirstOrDefaultAsync(x =>
                    x.RelationshipTypeId ==
                    relationshipType.RelationshipTypeId);

            if (existing == null)
                return null;

            existing.RelationshipName = relationshipType.RelationshipName;
            existing.IsActive = relationshipType.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteRelationshipType(int relationshipTypeId)
        {
            var relationshipType = await _db.RelationshipTypetbl
                .FirstOrDefaultAsync(x =>
                    x.RelationshipTypeId == relationshipTypeId);

            if (relationshipType == null)
                return false;

            _db.RelationshipTypetbl.Remove(relationshipType);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
