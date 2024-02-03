using controlWork_4;

ParrotsList parrots = new ParrotsList();
JsonUtil.CheckFile();
parrots = JsonUtil.GetParrotsList(ref parrots);

do
{
    Parrot userParrot = UserUtil.AskUserForNewParrot();
    parrots.Add(userParrot);
} while (UserUtil.AskUserToContinue("Do you want to add another NEW parrot? (YES - [Any key], NO - [n, no, e]"));


do
{
    UserUtil.AskUserToChooseParrot(parrots);
} while (UserUtil.AskUserToContinue("Do you want to add choose ANOTHER parrot? (YES - [Any key], NO - [n, no, e]"));
    
parrots.PrintAll();
JsonUtil.OverwriteFile(parrots);