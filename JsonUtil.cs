using System.Text.Json;

namespace controlWork_4;

public static class JsonUtil
{

    private static readonly string Path = "../../../Parrots.json";


    public static void CheckFile()
    {
        if (!File.Exists(Path))
        {
            File.Create(Path).Close();
        }
    }

    public static void OverwriteFile(ParrotsList parrotsList)
    {
        CheckFile();
        File.WriteAllText(Path, JsonSerializer.Serialize(parrotsList));
    }


    public static ParrotsList GetParrotsList(ref ParrotsList parrotsList)
    {
        CheckFile();


        if (string.IsNullOrWhiteSpace(File.ReadAllText(Path)))
        {
            return new ParrotsList();
        }

        Parrot[] parrotArray = JsonSerializer.Deserialize<Parrot[]>(File.ReadAllText(Path));

        foreach (Parrot parrot in parrotArray)
        {
            parrotsList.Add(parrot);
        }

        return parrotsList;
    }
}
