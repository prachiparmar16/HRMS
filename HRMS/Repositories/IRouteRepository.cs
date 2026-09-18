namespace HRMS.WebAPI.Repositories
{
    public interface IRouteRepository
    {
        Task<List<Route>> GetRoutes();
        Task<Route?> GetRouteById(int routeId);
        Task<Route> AddRoute(Route route);
        Task<Route?> UpdateRoute(Route route);
        Task<bool> DeleteRoute(int routeId);
    }
}
