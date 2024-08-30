using System.Runtime.InteropServices;

namespace FactoryPattern;

public interface IVehicle
{
   public int Wheels { get; set; }
   
   public void Drive();
}