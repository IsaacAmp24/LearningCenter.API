using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Domain.Services;

public interface ITutorialServiceAF
{
    Task<IEnumerable<TutorialAF>> ListAsync(); // READ
    Task<IEnumerable<TutorialAF>> ListByCategoryIdAsync(int categoryId);
    Task<TutorialResponseAF> SaveAsync(TutorialAF tutorial);   // CREATE
    Task<TutorialResponseAF> UpdateAsync(int id, TutorialAF tutorial); // UPDATE
    Task<TutorialResponseAF> DeleteAsync(int id); // DELETE
}