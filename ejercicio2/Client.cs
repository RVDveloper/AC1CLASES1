public class Client
{
    public string Name { get; set; }
    public string Dni { get; set; }
    public double DownPayment { get; set; }
    public float Payment { get; set; }

    public Client(string name, string dni, double downPayment, float payment)
    {
        Name = name;
        Dni = dni;
        DownPayment = downPayment;
        Payment = payment;
    }

    public void PrintClientData()
    {
        Console.WriteLine($"Client Name: {Name}");
        Console.WriteLine($"DNI: {Dni}");
        Console.WriteLine($"Down Payment: {DownPayment}");
        Console.WriteLine($"Payment: {Payment}");
    }
}
