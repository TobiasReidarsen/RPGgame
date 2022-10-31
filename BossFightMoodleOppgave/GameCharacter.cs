namespace BossFightMoodleOppgave;

public abstract class GameCharacter
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }
    public float Health { get; set; }
    public float Stamina { get; set; }
    public string CharacterType { get; set; }

    public virtual void SayName()
    {
        Console.WriteLine("My name is {0}!", Name);
    }

    protected virtual void CharacterCreated()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Created character.\n" +
                          "Type: {0}\n" +
                          "Name: {1}\n" +
                          "Health: {2}\n" +
                          "Stamina: {3}\n" +
                          "Description: {4}",
            CharacterType, Name, Health, Stamina, Description);
        Console.ReadKey(true);
        Console.SetCursorPosition(0, 0);
        Console.Clear();
    }
}