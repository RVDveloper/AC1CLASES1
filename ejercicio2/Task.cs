public class Task
{
    
    public string TaskName { get; set; }
    public string Status { get; set; } 
    public string Description { get; set; }

    
    public Task(string taskName, string status, string description)
    {
        TaskName = taskName;
        Status = status;
        Description = description;
    }
}
