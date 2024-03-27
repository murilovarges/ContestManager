using ContestManagerDomain.Entities;
using ContestManagerRepository.Context;
using ContestManagerService.Base;
using Microsoft.EntityFrameworkCore;

namespace ContestManagerService.Services;

public class ContestService : IContestService
{
    private readonly AppDbContext _context;

    public ContestService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Contest>> GetContests()
    {
        return await _context.Contests.ToListAsync();
    }
    public async Task<IEnumerable<Contest>> GetContestsByName(string name)
    {
        IEnumerable<Contest> contests;
        if (!string.IsNullOrEmpty(name))
        {
            contests = await _context.Contests.Where(c => c.Name.Contains(name)).ToListAsync();
        }
        else
        {
            contests = await GetContests();
        }
        return contests;
    }

    public async Task<Contest> GetContest(int id)
    {
        var contest = await _context.Contests.FindAsync(id);
        return contest;
    }

    public async Task CreateContest(Contest contest)
    {
        _context.Contests.Add(contest);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateContest(Contest contest)
    {
        _context.Entry(contest).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteContest(Contest contest)
    {
        _context.Contests.Remove(contest);
        await _context.SaveChangesAsync();
    }
}

