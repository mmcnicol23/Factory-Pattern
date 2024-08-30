namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            int userInput = int.Parse(Console.ReadLine());
            var wheels = VehicleFactory.GetVehicle(userInput);
            wheels.Drive();
        }
    }
}
