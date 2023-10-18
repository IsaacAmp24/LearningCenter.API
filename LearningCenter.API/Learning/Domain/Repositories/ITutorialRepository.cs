using LearningCenter.API.Learning.Domain.Models;

namespace LearningCenter.API.Learning.Domain.Repositories;

public interface ITutorialRepository
{
    Task<IEnumerable<TutorialAF>> ListAsync();
    Task AddAsync(TutorialAF tutorial);
    Task<TutorialAF> FindByIdAsync(int tutorialId);
    Task<TutorialAF> FindByTitleAsync(string title);
    Task<IEnumerable<TutorialAF>> FindByCategoryIdAsync(int categoryId);
    void Update(TutorialAF tutorial);
    void Remove(TutorialAF tutorial);
}