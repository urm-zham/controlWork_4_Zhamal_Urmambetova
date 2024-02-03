namespace controlWork_4;

public class Parrot
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Satiety { get; private set; }
    public int Mood { get; private set; }
    public int Health { get; private set; }
    public double LifeQuality => ((Satiety + Mood + Health) / 3.0);

    public Parrot(string name, int age)
    {
        Name = name;
        Age = age;
        Satiety = 10;
        Mood = 10;
        Health = 10;
    }

    public string GetParrotInfo()
    {
        return $"{Name,-7} | {Age,-4} | {Satiety,-7} | {Mood,-5} | {Health,-6} | {LifeQuality.ToString("F2"),-7}";
    }
}