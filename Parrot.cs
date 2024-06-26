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

    [JsonIgnore] public double LifeQuality => ((_satiety + _mood + _health) / 3.0);

    public int Satiety 
    { 
        get => _satiety;
        set => _satiety = value;
    }
    public int Mood 
    { 
        get => _mood;
        set => _mood = value;
    }
    public int Health 
    { 
        get => _health;
        set => _health = value;
    }

    public delegate void FoodPoisonHandler();
    public delegate void InjuryHandler();
    public delegate void GreatDoctorHandler();



    public event FoodPoisonHandler? FoodPoisoning;
    public event InjuryHandler? Injury;
    public event GreatDoctorHandler? GreatDoctor;



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

    public Parrot(int satiety, int mood, int health, string name, int age)
    {
        _satiety = satiety;
        _mood = mood;
        _health = health;
        Name = name;
        Age = age;
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
        if (new Random().Next(100) < 25)
        {
            FoodPoisoning?.Invoke();
            Console.WriteLine(Name + " had a food poisoning");
            _strategy.LowerMood(ref _mood);
            _strategy.LowerHealth(ref _health);
            PrintParrotInfo();
        }
    }
    
    public void Play()
    {
        Console.WriteLine("\nYou decided to play with " + Name);
        _strategy.Play(ref _satiety, ref _mood, ref _health);
        PrintParrotInfo();
        
        if (new Random().Next(100) < 25)
        {
            Injury?.Invoke();
            Console.WriteLine(Name + " got injured while playing");
            _strategy.LowerMood(ref _mood);
            _strategy.LowerHealth(ref _health);
            PrintParrotInfo();
        }
        
    }
    
    public void Heal()
    {
        Console.WriteLine("\nYou decided to heal " + Name);
        _strategy.Heal(ref _satiety, ref _mood, ref _health);
        PrintParrotInfo();
        if (new Random().Next(100) < 25)
        {
            GreatDoctor?.Invoke();
            Console.WriteLine(Name + "'s doctor was very professional");
            _strategy.IncreaseMood(ref _mood);
            _strategy.IncreaseHealth(ref _health);
            PrintParrotInfo();
        }
    }

    public void DoAction(string action)
    {
        switch (action.ToLower())
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