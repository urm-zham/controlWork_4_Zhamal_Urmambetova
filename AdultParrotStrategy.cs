namespace controlWork_4;

public class AdultParrotStrategy :IParrotStrategy
{
    public void Feed(ref int satiety, ref int mood)
    {
        satiety += 5;
        mood += 5;
    }

    public void Play(ref int satiety, ref int mood, ref int health)
    {
        satiety -= 5;
        mood += 5;
        health -= 5;
    }

    public void Heal(ref int satiety, ref int mood, ref int health)
    {
        satiety -= 5;
        mood -= 5;
        health += 5;
    }
}