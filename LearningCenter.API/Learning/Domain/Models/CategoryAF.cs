namespace LearningCenter.API.Learning.Domain.Models;

public class CategoryAF
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<TutorialAF> Tutorials { get; set; } = new List<TutorialAF>();

}