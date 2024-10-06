public class Project
{
    
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public int RemainingDays { get; set; }
    public Employee[] AssignedEmployees; 
    public Task[] ProjectTasks; 
    public decimal CostPerDay { get; set; }
    public string ProjectStatus { get; set; } 

    
    public Project(string projectName, string projectDescription, int remainingDays, decimal costPerDay, int maxEmployees, int maxTasks)
    {
        ProjectName = projectName;
        ProjectDescription = projectDescription;
        RemainingDays = remainingDays;
        CostPerDay = costPerDay;
        AssignedEmployees = new Employee[maxEmployees]; 
        ProjectTasks = new Task[maxTasks];
        ProjectStatus = "InProgress"; 
    }

    
    public decimal CalculateEstimatedCost()
    {
        return CostPerDay * RemainingDays;
    }

    
    public void AddEmployee(Employee employee, int index)
    {
        if (index < AssignedEmployees.Length)
        {
            AssignedEmployees[index] = employee;
        }
    }

    
    public void AddTask(Task task, int index)
    {
        if (index < ProjectTasks.Length)
        {
            ProjectTasks[index] = task;
        }
    }

    
    public int GetPendingTasksCount()
    {
        int pendingTasks = 0;
        for (int i = 0; i < ProjectTasks.Length; i++)
        {
            if (ProjectTasks[i] != null && ProjectTasks[i].Status == "Pending")
            {
                pendingTasks++;
            }
        }
        return pendingTasks;
    }

    
    public int GetEmployeeCount()
    {
        int employeeCount = 0;
        for (int i = 0; i < AssignedEmployees.Length; i++)
        {
            if (AssignedEmployees[i] != null)
            {
                employeeCount++;
            }
        }
        return employeeCount;
    }

    
    public void DisplayProjectInfo()
    {
        Console.WriteLine($"Project: {ProjectName}");
        Console.WriteLine($"Description: {ProjectDescription}");
        Console.WriteLine($"Remaining days: {RemainingDays}");
        Console.WriteLine($"Estimated cost: {CalculateEstimatedCost():C}");
        Console.WriteLine($"Status: {ProjectStatus}");
        Console.WriteLine($"Employees: {GetEmployeeCount()}");
        Console.WriteLine($"Pending tasks: {GetPendingTasksCount()}");
        Console.WriteLine("Assigned Employees:");
        
        
        for (int i = 0; i < AssignedEmployees.Length; i++)
        {
            if (AssignedEmployees[i] != null)
            {
                AssignedEmployees[i].PrintEmployeeData();
            }
        }
        
    }
}
