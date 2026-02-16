namespace LabPolymorphism;

public class Guitar : Instrument
{
    public Guitar(string name) : base(name) { }

    public override void PlaySound()
    {
        Console.WriteLine($"{Name} видає звук струн");
    }
}