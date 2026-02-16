using LabPolymorphism;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Audi", 180),
            new Bicycle("Giant", 25),
            new Airplane("Boeing 747", 900)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();

            if (vehicle is IRefuelable refuelable)
            {
                refuelable.Refill();
            }

            Console.WriteLine("---");
        }
    }
}