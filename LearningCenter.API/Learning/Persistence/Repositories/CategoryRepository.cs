using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Learning.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.API.Learning.Persistence.Repositories;

public class CategoryRepository : BaseRepository, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
    
        public async Task<IEnumerable<CategoryAF>> ListAsync()
        {
            return await _context.CategoryAfs.ToListAsync();
        }
    
        public async Task AddAsync(CategoryAF category)
        {
            await _context.CategoryAfs.AddAsync(category);
        }
    
        public async Task<CategoryAF> FindByIdAsync(int id)
        {
            return await _context.CategoryAfs.FindAsync(id);
        }
    
        public void Update(CategoryAF category)
        {
            _context.CategoryAfs.Update(category);
        }
    
        public void Remove(CategoryAF category)
        {
            _context.CategoryAfs.Remove(category);
        }
}