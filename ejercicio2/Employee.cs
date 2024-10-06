public class Employee
{
    public const string DeveloperFace = "👨‍💻";
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    
    public Employee(string name, string position, decimal salary)
    {
        Name = name;
        Position = position;
        Salary = salary;
    }

    public void PrintEmployeeData()
    {
        Console.WriteLine($"{DeveloperFace}Employee Name: {Name}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}
