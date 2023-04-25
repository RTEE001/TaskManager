namespace TaskManager.Models;

public class Job
{
    public int Id { get; set; }
    public string? JobTitle { get; set; }
    public string? JobDescription { get; set; }
    public DateTime JobDueDate { get; set; }
}