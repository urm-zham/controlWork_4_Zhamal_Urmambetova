namespace controlWork_4;

public class ParrotsList
{
    private List<Parrot> _parrots;

    public ParrotsList()
    {
        _parrots = new List<Parrot>();
    }

    public void Add(Parrot parrot)
    {
        _parrots.Add(parrot);
    }

    public void Sort()
    {
        _parrots.Sort((parrotA, parrotB) => parrotA.LifeQuality.CompareTo(parrotB.LifeQuality));
    }
    
    public void PrintAll()
    {
        Console.WriteLine("--------|------|---------|-------|--------|------------");
        Console.WriteLine("Name    | Age  | Satiety | Mood  | Health | LifeQuality");
        Console.WriteLine("--------|------|---------|-------|--------|------------");
        Sort();
        _parrots.ForEach(parrot => Console.WriteLine(parrot.GetParrotInfo()));
        Console.WriteLine("--------|------|---------|-------|--------|------------");

    }
}