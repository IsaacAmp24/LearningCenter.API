using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Services;

public class CategoryService : ICategoryServiceAF
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<CategoryAF>> ListAsync()
    {
        return await _categoryRepository.ListAsync();
    }
    
    public async Task<CategoryResponseAF> SaveAsync(CategoryAF category)
    {
        try
        {
            await _categoryRepository.AddAsync(category);
            await _unitOfWork.CompleteAsync();
            return new CategoryResponseAF(category);
        }
        catch (Exception e)
        {
            return new CategoryResponseAF("An error occurred when saving the category: " + e.Message);
        }
    }

    public async Task<CategoryResponseAF> UpdateAsync(int id, CategoryAF categoryAf)
    {
        var existingCategory = await _categoryRepository.FindByIdAsync(id);
        
        if (existingCategory == null)
            return new CategoryResponseAF("Category not found.");
        
        existingCategory.Name = categoryAf.Name;
        
        try
        {
            _categoryRepository.Update(existingCategory);
            await _unitOfWork.CompleteAsync();
            
            return new CategoryResponseAF(existingCategory);
        }
        catch (Exception e)
        {
            return new CategoryResponseAF("An error occurred when updating the category: " + e.Message);
        }
    }

    public async Task<CategoryResponseAF> DeleteAsync(int id)
    {
        var existingCategory = await _categoryRepository.FindByIdAsync(id);
        
        if (existingCategory == null)
            return new CategoryResponseAF("Category not found.");
        
        try 
        {
            _categoryRepository.Remove(existingCategory);
            await _unitOfWork.CompleteAsync();
            
            return new CategoryResponseAF(existingCategory);
        }
        catch (Exception e)
        {
            return new CategoryResponseAF("An error occurred when deleting the category: " + e.Message);
        }
    }
}