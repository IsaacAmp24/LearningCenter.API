using LearningCenter.API.Learning.Persistence.Context;

namespace LearningCenter.API.Learning.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}