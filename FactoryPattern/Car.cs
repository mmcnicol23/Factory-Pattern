namespace FactoryPattern;

public class Car : IVehicle
{
    public int Wheels { get; set; }
    public void Drive()
    {
        Console.WriteLine("This is a car");
    }
}