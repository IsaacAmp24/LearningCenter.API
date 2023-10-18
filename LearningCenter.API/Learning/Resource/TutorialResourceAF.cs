namespace LearningCenter.API.Learning.Resource;

public class TutorialResourceAF
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
    public CategoryResourceAF Category { get; set; }
    
}