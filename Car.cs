namespace LabPolymorphism;

public class Car : Vehicle, IRefuelable
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"{Brand} їде по трасі зі швидкістю {Speed} км/год");
    }

    public void Refill()
    {
        Console.WriteLine($"{Brand} заправляється бензином");
    }
}