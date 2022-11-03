using System.Reflection.Emit;

namespace BossFightMoodleOppgave;

public abstract class GameCharacter
{
    // #TODO should I use protected here or public?
    protected string Name { get; set; } // should these be abstract?
    protected string Description { get; set; }
    protected int Age { get; set; }
    protected string CharacterType { get; set; }
    protected int CharacterLvl { get; set; }
    protected float Health { get; set; }
    protected float Vitality { get; set; }
    protected float Stamina { get; set; }
    protected float Endurace { get; set; }
    

    
    public float GetHealth() => Health;
    public float GetStamina() => Stamina;
    public string GetName() => Name;
    public int GetCharLvl() => CharacterLvl;

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