namespace BossFightMoodleOppgave;

public class Boss : Enemy   
{
    public Boss(string name, string description, int age, float health, float stamina, int str)
    {
        Name = name;
        Description = description;
        Age = age;
        Health = health;
        Stamina = stamina;
        Str = str;
        CharacterType = "Boss";
        base.CharacterCreated();
    }
    
    public Boss()
    {
        Name = "Bosser Man";
        Description = "Very strong, but slow and stupid (and boring at parties)";
        Age = 600;
        Health = 400;
        Str = 30;
        Stamina = 10;
        CharacterType = "Boss";
        base.CharacterCreated();
        //CharacterCreated(true); // kan da bruke den virtuelle istedenfor den som er overrida
    }
}