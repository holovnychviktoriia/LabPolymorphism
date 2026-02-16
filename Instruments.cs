namespace LabPolymorphism;

public abstract class Instrument
{
    public string Name { get; set; }

    public Instrument(string name)
    {
        Name = name;
    }

    public abstract void PlaySound();
}