using controlWork_4;

List<Parrot> parrots = new List<Parrot>();
parrots.Add(new Parrot("Chipi", 1));
Console.WriteLine("Name    | Age  | Satiety | Mood  | Health | LifeQuality");
Console.WriteLine("--------|------|---------|-------|--------|------------");

parrots.ForEach(parrot => Console.WriteLine(parrot.GetParrotInfo()));

string userParrotName = UserUtil.AskUser<string>("Please enter new parrot's name:");
int userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's age:");

parrots.Add(new Parrot(userParrotName, userParrotAge));

parrots.Sort((parrotA, parrotB) => parrotA.LifeQuality.CompareTo(parrotB.LifeQuality));

parrots.ForEach(parrot => Console.WriteLine(parrot.GetParrotInfo()));
