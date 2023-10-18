using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Resource;
using Microsoft.AspNetCore.Http.HttpResults;

namespace LearningCenter.API.Learning.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveCategoryResourceAF, CategoryAF>();
        CreateMap<SaveTutorialResourceAF, TutorialAF>();
    }
}