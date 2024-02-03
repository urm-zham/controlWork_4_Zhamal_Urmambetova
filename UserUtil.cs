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
}