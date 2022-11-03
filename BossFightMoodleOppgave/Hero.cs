namespace BossFightMoodleOppgave;

public class Hero : FighterCharacters
{
    public Hero(string name, string description, int age, float health, float stamina, int str, int characterLvl)
    {
        Name = name;
        Description = description;
        Age = age;
        Health = health;
        Stamina = stamina;
        //Str = str;
        CharacterType = "Hero";
        CharacterLvl = characterLvl;
        base.CharacterCreated();
    }

    public Hero()
    {
        Name = "Giga Hero Schmo";
        Description = "Very smart";
        Age = 19;
        Health = 100;
        //Str = 20;
        Stamina = 40;
        CharacterType = "Hero";
        CharacterLvl = 1;
        base.CharacterCreated();
    }
}