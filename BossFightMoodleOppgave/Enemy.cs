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
    
    public Enemy()
    {
        Name = "Little Man";
        Description = "Fodder enemy. Nothing more to it";
        Age = 45;
        Health = 30;
        Str = 7;
        Stamina = 15;
        CharacterType = "Enemy";
        base.CharacterCreated();
    }

}