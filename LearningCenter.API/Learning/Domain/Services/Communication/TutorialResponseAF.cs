using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Shared.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Domain.Services.Communication;

public class TutorialResponseAF : BaseResponse<TutorialAF>
{
    public TutorialResponseAF(string message) : base(message)
    {
        
    }

    public TutorialResponseAF(TutorialAF resource) : base(resource)
    {
        
    }
}