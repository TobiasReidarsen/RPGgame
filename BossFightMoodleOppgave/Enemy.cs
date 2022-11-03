namespace BossFightMoodleOppgave;

public class Enemy : GameCharacter
{
    public Enemy(bool standard)
    {
        CharacterType = "Enemy";
        Name = "Regular Joe Schmooooo";
        Console.Write(CharacterType);
        Console.Write(Name);
        Console.Write(Health);
    }

    public Enemy()
    {
        
    }
}