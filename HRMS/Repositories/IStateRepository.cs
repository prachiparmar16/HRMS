using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IStateRepository
    {
        Task<List<State>> GetStates();
        Task<State?> GetStateById(int stateId);
        Task<State> AddState(State state);
        Task<State?> UpdateState(State state);
        Task<bool> DeleteState(int stateId);
    }
}
