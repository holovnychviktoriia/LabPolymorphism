namespace LabPolymorphism;

public class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Brand} їде по велодоріжці зі швидкістю {Speed} км/год");
    }
}