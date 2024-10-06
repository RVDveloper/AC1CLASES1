internal class Program
{
    private static void Main(string[] args)
    {
       
        Employee employee1 = new Employee("Marc Callejon", "Developer", 3500);
        Employee employee2 = new Employee("Zaha Hadid", "Designer", 3000);

        
        Task task1 = new Task("Design User Interface", "Pending", "Design the user interface");
        Task task2 = new Task("Implement Backend", "InProgress", "Develop the backend API");

        
        Project project = new Project("Mobile App", "Develop a mobile application", 30, 500, 5, 10);

        
        project.AddEmployee(employee1, 0);
        project.AddEmployee(employee2, 1);

        
        project.AddTask(task1, 0);
        project.AddTask(task2, 1);

        
        project.DisplayProjectInfo();
    }
}