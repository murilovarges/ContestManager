using ContestManagerDomain.Entities;

namespace ContestManagerService.Base;

public interface IContestService
{
    Task<IEnumerable<Contest>> GetContests();
    Task<Contest> GetContest(int id);
    Task<IEnumerable<Contest>> GetContestsByName(string name);
    Task CreateContest(Contest contest);
    Task UpdateContest(Contest contest);
    Task DeleteContest(Contest contest);
}