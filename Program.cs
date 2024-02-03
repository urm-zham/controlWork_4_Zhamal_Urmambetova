using controlWork_4;

ParrotsList parrots = new ParrotsList();
parrots.Add(new Parrot("Chipi", 1));
parrots.PrintAll();

string userParrotName = UserUtil.AskUser<string>("Please enter new parrot's NAME:");
int userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's AGE:");

while (!(userParrotAge >= 0 && userParrotAge <= 50))
{
    Console.WriteLine("Enter AGE between 0 and 50!");
    userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's AGE:");
}

Parrot userParrot = new Parrot(userParrotName, userParrotAge);
parrots.Add(userParrot);

parrots.PrintAll();

parrots.GetRandom().Play();
parrots.SearchByNameAge(userParrotName, userParrotAge).Feed();
parrots.GetRandom().Heal();

parrots.PrintAll();


