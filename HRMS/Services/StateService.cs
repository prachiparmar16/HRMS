using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class StateService : IStateRepository
    {
        private readonly HrmsDbContext _db;

        public StateService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<State>> GetStates()
            => await _db.Statetbl.ToListAsync();

        public async Task<State?> GetStateById(int stateId)
            => await _db.Statetbl
                .FirstOrDefaultAsync(x => x.StateId == stateId);

        public async Task<State> AddState(State state)
        {
            _db.Statetbl.Add(state);
            await _db.SaveChangesAsync();
            return state;
        }

        public async Task<State?> UpdateState(State state)
        {
            var existing = await _db.Statetbl
                .FirstOrDefaultAsync(x => x.StateId == state.StateId);

            if (existing == null)
                return null;

            existing.StateName = state.StateName;
            existing.CountryId = state.CountryId;
            existing.IsActive = state.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteState(int stateId)
        {
            var state = await _db.Statetbl
                .FirstOrDefaultAsync(x => x.StateId == stateId);

            if (state == null)
                return false;

            _db.Statetbl.Remove(state);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
