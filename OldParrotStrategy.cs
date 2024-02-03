namespace controlWork_4;

public class OldParrotStrategy : IParrotStrategy 
{
    public void Feed(ref int satiety, ref int mood)
    {
        satiety += 2;
        mood += 2;
    }

    public void Play(ref int satiety, ref int mood, ref int health)
    {
        satiety -= 10;
        mood += 2;
        health -= 10;
    }

    public void Heal(ref int satiety, ref int mood, ref int health)
    {
        satiety -= 10;
        mood -= 10;
        health += 2;
    }
}