namespace controlWork_4;

public class YoungParrotStrategy : IParrotStrategy
{
    public void Feed(ref int satiety, ref int mood)
    {
        satiety += 10;
        mood += 10;
    }

    public void Play(ref int satiety, ref int mood, ref int health)
    {
        satiety -= 2;
        mood += 10;
        health -= 2;
    }

    public void Heal(ref int satiety, ref int mood, ref int health)
    {
        satiety -= 2;
        mood -= 2;
        health += 10;
    }
}