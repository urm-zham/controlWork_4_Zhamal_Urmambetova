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
    
    public void LowerSatiety(ref int satiety)
    {
        satiety -= 5;
    }

    public void IncreaseSatiety(ref int satiety)
    {
        satiety += 5;
    }

    public void LowerMood(ref int mood)
    {
        mood -= 5;
    }

    public void IncreaseMood(ref int mood)
    {
        mood += 5;
    }

    public void LowerHealth(ref int health)
    {
        health -= 5;
    }

    public void IncreaseHealth(ref int health)
    {
        health += 5;
    }
}