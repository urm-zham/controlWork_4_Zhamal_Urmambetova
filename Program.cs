using controlWork_4;

ParrotsList parrots = new ParrotsList();
parrots.Add(new Parrot("Chipi", 1));
parrots.PrintAll();

string userParrotName = UserUtil.AskUser<string>("Please enter new parrot's name:");
int userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's age:");

while (!(userParrotAge >= 0 && userParrotAge <= 50))
{
    Console.WriteLine("Enter age between 0 and 50!");
    userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's age:");
}

parrots.Add(new Parrot(userParrotName, userParrotAge));

parrots.PrintAll();
