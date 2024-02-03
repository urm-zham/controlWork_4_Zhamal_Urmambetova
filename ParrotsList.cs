namespace controlWork_4;

public class ParrotsList
{
    private List<Parrot> _parrots;
    public int Count => _parrots.Count;

    public ParrotsList()
    {
        _parrots = new List<Parrot>();
    }

    public void Add(Parrot parrot)
    {
        _parrots.Add(parrot);
        PrintAll();
    }

    public void Sort()
    {
        _parrots.Sort((parrotA, parrotB) => parrotA.LifeQuality.CompareTo(parrotB.LifeQuality));
    }

    public Parrot GetRandom()
    {
        if (_parrots.Count > 0)
            return _parrots[new Random().Next(_parrots.Count())];
        return null;
    }
    
    public Parrot SearchByNameAge(string name, int age)
    {
        if (_parrots.Count > 0)
            return _parrots.FirstOrDefault(parrot => parrot.Name == name && parrot.Age == age);
        return null;
    }
    
    public Parrot? SearchByName(string name)
    {
        if (_parrots.Count > 0)
            return _parrots.FirstOrDefault(parrot => parrot.Name == name);
        return null;
    }
    
    
    public void PrintAll()
    {
        if (_parrots.Count > 0)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n--------|------|---------|-------|--------|------------");
            Console.WriteLine("Name    | Age  | Satiety | Mood  | Health | LifeQuality");
            Console.WriteLine("--------|------|---------|-------|--------|------------");
            Sort();
            _parrots.ForEach(parrot => Console.WriteLine(parrot.GetParrotInfo()));
            Console.WriteLine("--------|------|---------|-------|--------|------------\n");

            Console.ForegroundColor = defaultColor;
        }
    }
}