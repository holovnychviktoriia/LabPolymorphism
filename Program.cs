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

        Console.WriteLine("\n--- Завдання 2 (варіант 7) ---");
        
        List<Instrument> orchestra = new List<Instrument>
        {
            new Piano("Piano 1"),
            new Guitar("Guitar 1"),
            new Drums("Drums 1")
        };

        foreach (var instrument in orchestra)
        {
            instrument.PlaySound();
        }

        Console.WriteLine("\n--- Завдання 3 ---");
        
        List<Artifact> inventory = new List<Artifact>
        {
            new Artifact(1),
            new AncientSword(2),
            new MagicScroll(3)
        };

        foreach (var item in inventory)
        {
            item.Identify();
        }
    }
}