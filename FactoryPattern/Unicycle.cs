namespace FactoryPattern;

public class Unicycle : IVehicle
{
    public int Wheels { get; set; }
    public void Drive()
    {
        Console.WriteLine("This is a unicycle");
    }
}