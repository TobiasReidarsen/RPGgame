namespace BossFightMoodleOppgave;

public class Enemy : FighterCharacters
{
    public Enemy(string name, string description, int age, float health, float stamina, int str)
    {
        Name = name;
        Description = description;
        Age = age;
        Health = health;
        Stamina = stamina;
        Str = str;
        CharacterType = "Enemy";
        base.CharacterCreated();
    }
}