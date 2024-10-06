public class Supplier
{
    public string Name { get; set; }
    public string Dni { get; set; }

    public Supplier(string name, string dni)
    {
        Name = name;
        Dni = dni;
    }

    public void PrintSupplierData()
    {
        Console.WriteLine($"Supplier Name: {Name}");
        Console.WriteLine($"DNI: {Dni}");
    }
}
