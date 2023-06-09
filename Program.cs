using ClassLibraries; 

class Program
{
    static List<Vehicle> vehicles = new List<Vehicle>();
    static void Main(string[] args)
    {
        Vehicle landVehicle = new Land("Red", 4);
        Sea seaVehicle = new Sea("Green", Sea.BoatType.Submarine);
        Plane plane = new Plane("Pink", 1);
        Helicopter helicopter = new Helicopter("Orange", 2);

        vehicles.Add(landVehicle);
        vehicles.Add(seaVehicle);
        vehicles.Add(plane);
        vehicles.Add(helicopter);

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle.ToString());
        }
    }
}

    
