namespace controlWork_4;

public interface IParrotStrategy
{
    void Feed(ref int satiety, ref int mood);
    void Play(ref int satiety, ref int mood, ref int health);
    void Heal(ref int satiety, ref int mood, ref int health);
}