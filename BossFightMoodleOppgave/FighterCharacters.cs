namespace BossFightMoodleOppgave;

public abstract class FighterCharacters : GameCharacter
{
    // #TODO make a level system.

    protected double BaseDamagePhys { get; set; }

    protected int Str { get; set; }
    protected int StrLvl { get; set; }

    public virtual int SetStrenght()
    {
        // Str is StrLvl times any modifiers such as weapons or passive or active skills or anything else.
        Str = StrLvl * 3;
        return Str;
    }
    
    public virtual double BasePhysDamageCalc(int protagStr, int protagLvl)
    {
        double protagDmgMltplr = Math.Pow(1.1, protagLvl);
        double baseDamage = protagStr * protagDmgMltplr;
        return baseDamage;
    }

    public int GetStr(bool random)
    {
        if (CharacterType == "Boss")
        {
            int _str = new Random().Next(0, Str + 1);
            return _str;
        }

        return Str;
    }

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

        //base.CharacterCreated();
        //Console.WriteLine("base.charactercreated");
    }

    protected void CharacterCreated(bool kjør)
    {
        if (kjør)
        {
            base.CharacterCreated(); // kan da bruke den virtuelle istedenfor den som er overrida
            return;
        }

        CharacterCreated();
    }


    public virtual float SubtractDefenceFromDamage(float baseDamage, float flatDefense, float percentageDefense)
    {
        baseDamage -= flatDefense;
        Console.WriteLine(baseDamage);
        baseDamage *= percentageDefense;
        Console.WriteLine(baseDamage);
        float finalDamage = baseDamage;
        return finalDamage;
    }


    // public virtual void Fight(GameCharacter nowHero, GameCharacter opponent, string oponentType)
    // {
    //     /*
    //     int heroStr = hero.GetStr();
    //     float heroHealth = GetHealth();
    //     int opponentStr = opponent.GetStr();
    //     float opponentHealth = opponent.GetHealth();
    //     float opponentStamina = opponent.GetStamina();
    //     Console.WriteLine(heroStr);
    //     Console.WriteLine(opponentStr);
    //     Console.WriteLine("Oponent Health: " + opponentHealth + "\nOponent GetHealth()" + opponent.GetHealth() + "\nHero health: " + hero.GetHealth() + " and: " + heroHealth);
    //     opponentHealth -= hero.GetStr();
    //     Console.WriteLine("Oponent Health: " + opponentHealth + "\nOponent GetHealth()" + opponent.GetHealth() + "\nHero health: " + hero.GetHealth() + " and: " + heroHealth);
    //     */
    //     bool randomStr;
    //     var heroStamina = nowHero.GetStamina();
    //     var opponentStamina = opponent.GetStamina();
    //     float opponentHealth = opponent.GetHealth();
    //     float heroHealth = nowHero.GetHealth();
    //     int opponentStr = 0;
    //     var cursorPos = Console.GetCursorPosition();
    //     int cursorX;
    //     int cursorY;
    //     //float damage = Str #TODO Make damage dealt more complext. Tie it to level and resistance. 
    //     randomStr = oponentType != "Hero";
    //     while (true)
    //     {
    //     string fightingText = "Fight Started!\n" +
    //                           $"You have encountered a {oponentType}, whose name is {opponent.GetName()}\n" +
    //                           $"Their stats:\nMax health: {opponent.GetHealth()} Current health: {opponentHealth}\n" +
    //                           $"Maximum Str: {opponent.GetStr(false)}\n";
    //     string heroStatsAfterFight = $"You hit {opponent.GetName()} with {Str} strenght for {Str} damage!\n" +
    //                                  $"You lost {Stamina - heroStamina} stamina! {Stamina}\n";
    //     string opponentStatsAfterFight =
    //         $"{opponent.GetName()} hit you with {opponentStr} strenght for {opponentStr} damage!\n" +
    //         $"{opponent.GetName()} lost {opponent.GetStamina() - opponentStamina}\n"; //#TODO refactor this one and the one above into one thing.
    //
    //
    //         opponentStr = GetStr(true);
    //
    //         opponentHealth -= Str;
    //         heroStamina -= 10;
    //
    //         heroHealth -= opponentStr;
    //         opponentStamina -= 10;
    //         
    //         Console.WriteLine(fightingText);
    //         Console.ReadKey(true);
    //         Console.Clear();
    //         Console.WriteLine(fightingText, heroStatsAfterFight);
    //         Console.ReadKey(true);
    //         Console.Clear();
    //         Console.WriteLine(fightingText, opponentStatsAfterFight);
    //         Console.ReadKey(true);
    //         Console.Clear();
    //
    //
    //     }
    //
    //   
    // }

    public virtual void Restore()
    {
        // restores stamina
    }
    
}