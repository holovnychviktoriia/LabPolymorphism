namespace LabPolymorphism;

public class Drums : Instrument
{
    public Drums(string name) : base(name) { }

    public override void PlaySound()
    {
        Console.WriteLine($"{Name} задає ритм ударами");
    }
}