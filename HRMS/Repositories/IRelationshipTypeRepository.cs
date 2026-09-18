using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IRelationshipTypeRepository
    {
        Task<List<RelationshipType>> GetRelationshipTypes();
        Task<RelationshipType?> GetRelationshipTypeById(int relationshipTypeId);
        Task<RelationshipType> AddRelationshipType(RelationshipType relationshipType);
        Task<RelationshipType?> UpdateRelationshipType(RelationshipType relationshipType);
        Task<bool> DeleteRelationshipType(int relationshipTypeId);

    }
}
