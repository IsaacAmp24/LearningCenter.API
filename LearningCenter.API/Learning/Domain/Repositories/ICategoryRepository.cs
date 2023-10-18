using LearningCenter.API.Learning.Domain.Models;

namespace LearningCenter.API.Learning.Domain.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<CategoryAF>>ListAsync();
    Task AddAsync(CategoryAF category);
    Task<CategoryAF> FindByIdAsync(int id);
    void Update(CategoryAF category);
    void Remove(CategoryAF category);
}