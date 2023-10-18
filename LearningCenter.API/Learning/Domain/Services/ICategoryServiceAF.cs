using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Domain.Services;

public interface ICategoryServiceAF
{
    //CRUD
    Task<IEnumerable<CategoryAF>> ListAsync(); // READ
    Task<CategoryResponseAF> SaveAsync(CategoryAF category); // CREATE
    Task<CategoryResponseAF> UpdateAsync(int id, CategoryAF category); // UPDATE
    Task<CategoryResponseAF> DeleteAsync(int id); // DELETE
}