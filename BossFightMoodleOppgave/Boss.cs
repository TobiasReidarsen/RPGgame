namespace BossFightMoodleOppgave;

public class Boss : Enemy   
{
    public Boss()
    {
        CharacterType = "Boss";
        Console.WriteLine(CharacterType);
        Console.WriteLine(Health);
        Console.WriteLine(CharacterLvl);
        Console.WriteLine(CharacterType);
    }
    
}