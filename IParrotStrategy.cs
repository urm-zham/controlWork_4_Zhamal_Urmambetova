namespace controlWork_4;

public interface IParrotStrategy
{
    void Feed(ref int satiety, ref int mood);
    void Play(ref int satiety, ref int mood, ref int health);
    void Heal(ref int satiety, ref int mood, ref int health);

    void LowerSatiety(ref int satiety);
    void IncreaseSatiety(ref int satiety);
    void LowerMood(ref int mood);
    void IncreaseMood(ref int mood);
    void LowerHealth(ref int health);
    void IncreaseHealth(ref int health);
}