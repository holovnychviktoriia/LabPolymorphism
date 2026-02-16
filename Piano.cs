namespace LabPolymorphism;

public class Piano : Instrument
{
    public Piano(string name) : base(name) { }

    public override void PlaySound()
    {
        Console.WriteLine($"{Name} грає мелодію клавішами");
    }
}