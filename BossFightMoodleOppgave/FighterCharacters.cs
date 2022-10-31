namespace BossFightMoodleOppgave;

public abstract class FighterCharacters : GameCharacter
{
    public int Str { get; set; }

    protected override void CharacterCreated()
    {
        Console.WriteLine("Created character.\n" +
                          "Type: {0}\n" +
                          "Name: {1}\n" +
                          "Health: {2}\n" +
                          "Stamina: {3}\n" +
                          "Str: {4}\n" +
                          "Description: {5}",
            CharacterType, Name, Health, Stamina, Str, Description);
        Console.ReadKey(true);
        Console.Clear();
    }

    public virtual void Fight()
    {
    }

    public virtual void Restore()
    {
        // restores stamina
    }
}