namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(int wheels)
    
    
    {
        switch (wheels)
        {
            case 1:
                return new Unicycle();
            case 2:
                return new Motorcycle();
            case 3:
                return new Tricycle();
            case 4:
                return new Car();
            default:
                return new Car();
                //Console.WriteLine("Sorry, I don't know what kind of vehicle has that many wheels!");
                break;
        }

        return null;
    }
}