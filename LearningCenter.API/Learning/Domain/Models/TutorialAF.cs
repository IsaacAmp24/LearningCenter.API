namespace LearningCenter.API.Learning.Domain.Models;

public class TutorialAF
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    //Relationships
    public int CategoryId { get; set; }
    public CategoryAF Category { get; set; }
    

}