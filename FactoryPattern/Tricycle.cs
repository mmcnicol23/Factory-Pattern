namespace FactoryPattern;

public class Tricycle : IVehicle
{
    public int Wheels { get; set; }
    public void Drive()
    {
        Console.WriteLine("This is a tricycle");
    }
}