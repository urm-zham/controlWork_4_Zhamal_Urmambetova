namespace controlWork_4;

public static class UserUtil
{
    public static T AskUser<T>(string question)
    {
        T userInput;
        while (true)
        {
            Console.WriteLine(question);
            string inputStr = Console.ReadLine().Trim();

            try
            {
                userInput = (T)Convert.ChangeType(inputStr, typeof(T));
                break;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine($"Wrong type!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter correct value!");
            }

        }

        return userInput;
    }

    public static bool AskUserToContinue(string question)
    {
        Console.WriteLine(question);
        string userInput = Console.ReadLine()!.Trim().ToLower();

        if (userInput == "e" || userInput == "n" || userInput == "no")
        {
            return false;
        }

        return true;
    }

    public static Parrot AskUserForNewParrot()
    {
        string userParrotName = UserUtil.AskUser<string>("Please enter new parrot's NAME:");
        int userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's AGE:");

        while (!(userParrotAge >= 0 && userParrotAge <= 50))
        {
            Console.WriteLine("Enter AGE between 0 and 50!");
            userParrotAge = UserUtil.AskUser<int>("Please enter new parrot's AGE:");
        }

        Parrot userParrot = new Parrot(userParrotName, userParrotAge);
        return userParrot;
    }

    public static string AskUserForAction()
    {
        string userAction = UserUtil.AskUser<string>("Choose one ACTION - play, feed, heal:");

        while (!(userAction == "play" || userAction == "feed" || userAction == "heal"))
        {
            Console.WriteLine("Wrong action!");
            userAction = UserUtil.AskUser<string>("Choose one ACTION - play, feed, heal:");
        }

        return userAction;
    }

    public static void AskUserToChooseParrot(ParrotsList parrots)
    {
        string chosenParrotName = UserUtil.AskUser<string>("Choose parrot's NAME from the LIST:");
        Parrot? chosenParrot = parrots.SearchByName(chosenParrotName);

        if (chosenParrot != null)
        {
            string userAction = UserUtil.AskUserForAction();
            chosenParrot.DoAction(userAction);

            while (UserUtil.AskUserToContinue("Do you want do another ACTION? (YES - [Any key], NO - [n, no, e]"))
            {
                userAction = UserUtil.AskUserForAction();
                chosenParrot.DoAction(userAction);
            }
        }
        else
        {
            Console.WriteLine("Parrot not found");
        }
    }
}