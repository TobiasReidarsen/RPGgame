namespace BossFightMoodleOppgave;

public abstract class FighterCharacters : GameCharacter
{
    protected int Str { get; set; }

    protected override void CharacterCreated()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write("Created character.\n" +
                          "Type: {0}\n" +
                          "Name: {1}\n" +
                          "Health: {2}\n" +
                          "Stamina: {3}\n" +
                          "Str: {4}\n" +
                          "Description: {5}",
            CharacterType, Name, Health, Stamina, Str, Description);
        Console.ReadKey(true);
        Console.SetCursorPosition(0, 0);
        Console.Clear();
    }

    public virtual void Fight(GameCharacter hero, GameCharacter opponent)
    {
        Console.WriteLine(Str);
        opponent.Health -= Str;
    }

    public virtual void Restore()
    {
        // restores stamina
    }
}