using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Shared.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Domain.Services.Communication;

public class CategoryResponseAF : BaseResponse<CategoryAF>
{
    public CategoryResponseAF(string message) : base(message)
    {
        
    }

    public CategoryResponseAF(CategoryAF resource) : base(resource)
    {
        
    }
}