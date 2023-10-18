using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Resource;

namespace LearningCenter.API.Learning.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<CategoryAF, CategoryResourceAF>();
        CreateMap<TutorialAF, TutorialResourceAF>();
    }
}