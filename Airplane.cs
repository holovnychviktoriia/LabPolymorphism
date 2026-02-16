namespace LabPolymorphism;

public class Airplane : Vehicle, IRefuelable
{
    public Airplane(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Brand} летить у небі зі швидкістю {Speed} км/год");
    }

    public void Refill()
    {
        Console.WriteLine($"{Brand} заправляється авіаційним пальним");
    }
}