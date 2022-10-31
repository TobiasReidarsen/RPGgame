namespace BossFightMoodleOppgave;

public class Hero : FighterCharacters
{
    public Hero(string name, string description, int age, float health, float stamina, int str)
    {
        Name = name;
        Description = description;
        Age = age;
        Health = health;
        Stamina = stamina;
        Str = str;
        CharacterType = "Hero";
        base.CharacterCreated();
    }
}