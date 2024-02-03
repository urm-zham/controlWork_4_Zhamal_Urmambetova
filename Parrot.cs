using System.Text.Json.Serialization;

namespace controlWork_4;

public class Parrot
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    private int _satiety;
    private int _mood;
    private int _health;
    [JsonIgnore] private IParrotStrategy _strategy;
    // public int Satiety { get; private set; }
    // public int Mood { get; private set; }
    // public int Health { get; private set; }

    [JsonIgnore] public double LifeQuality => ((_satiety + _mood + _health) / 3.0);

    public int Satiety 
    { 
        get => _satiety;
        private set => _satiety = value;
    }
    public int Mood 
    { 
        get => _mood;
        private set => _mood = value;
    }
    public int Health 
    { 
        get => _health;
        private set => _health = value;
    }


    public Parrot(string name, int age)
    {
        Name = name;
        Age = age;
        _satiety = Satiety;
        _satiety = 10;
        _mood = Mood;
        _mood = 10;
        _health = Health;
        _health = 10;
        setStrategy(age);
    }

    public string GetParrotInfo()
    {
        return $"{Name,-7} | {Age,-4} | {_satiety,-7} | {_mood,-5} | {_health,-6} | {LifeQuality,-7:F2}";
    }
    
    public void PrintParrotInfo()
    {
        Console.WriteLine("Name    | Age  | Satiety | Mood  | Health | LifeQuality");
        Console.WriteLine("--------|------|---------|-------|--------|------------");
        Console.WriteLine($"{Name,-7} | {Age,-4} | {_satiety,-7} | {_mood,-5} | {_health,-6} | {LifeQuality,-7:F2}\n");
    }

    private void setStrategy(int age)
    {
        if (age >= 0 && age <= 5)
            _strategy = new YoungParrotStrategy();
        else if (age >= 6 && age <= 10)
            _strategy = new AdultParrotStrategy();
        else if (age > 10)
            _strategy = new OldParrotStrategy();
    }

    public void Feed()
    {
        Console.WriteLine("\nYou decided to feed " + Name);
        _strategy.Feed(ref _satiety, ref _mood);
        PrintParrotInfo();
    }
    
    public void Play()
    {
        Console.WriteLine("\nYou decided to play with " + Name);
        _strategy.Play(ref _satiety, ref _mood, ref _health);
        PrintParrotInfo();
    }
    
    public void Heal()
    {
        Console.WriteLine("\nYou decided to heal " + Name);
        _strategy.Heal(ref _satiety, ref _mood, ref _health);
        PrintParrotInfo();
    }

    public void DoAction(string action)
    {
        switch (action)
        {
            case "play" :
                Play();
                break;
            case "feed" :
                Feed();
                break;
            case "heal" :
                Heal();
                break;
            default:
                Console.WriteLine("Action not found.");
                break;
        }
    }
}