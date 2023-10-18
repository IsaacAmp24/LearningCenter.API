using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Resource;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Learning.Controllers;

[ApiController]
[Route("/api/[controller]")]

public class CategoriesControllers : ControllerBase
{
    private readonly ICategoryServiceAF _categoryService;
    private readonly IMapper _mapper;
    
    public CategoriesControllers(ICategoryServiceAF categoryService, IMapper mapper)
    {
        _categoryService = categoryService; 
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<CategoryResourceAF>> GetAllAsync()
    {
        var categories = await _categoryService.ListAsync();
        var resources = _mapper.Map<IEnumerable<CategoryAF>, IEnumerable<CategoryResourceAF>>(categories);
        return resources;
    }
}