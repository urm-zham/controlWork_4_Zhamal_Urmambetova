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

    public void LowerSatiety(ref int satiety)
    {
        satiety -= 2;
    }

    public void IncreaseSatiety(ref int satiety)
    {
        satiety += 10;
    }

    public void LowerMood(ref int mood)
    {
        mood -= 2;
    }

    public void IncreaseMood(ref int mood)
    {
        mood += 10;
    }

    public void LowerHealth(ref int health)
    {
        health -= 2;
    }

    public void IncreaseHealth(ref int health)
    {
        health += 10;
    }
}