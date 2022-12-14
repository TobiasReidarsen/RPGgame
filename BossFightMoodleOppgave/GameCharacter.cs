using System.Reflection.Emit;

namespace BossFightMoodleOppgave;

public abstract class GameCharacter
{
    // #TODO Implement a hit chance.
    protected string CharacterType { get; set; }

    // Default is "Empty_Came_Character"
    protected string Name { get; set; }


    // Increases Health by 10 every characterLvl
    // Can be increased by gaining xp or finding a lvl book.
    protected int CharacterLvl { get; set; }

    // the sum of vig, CharacterLvl, End, Str, Bra etc.
    // The sum of all stat lvls. Used in calculation of health.
    protected int TotalLvl { get; set; }

    // Vigor. The more vigor, the more health and stamina and damage resistance // Default is 10
    // Increases by health by 10 per character lcl, and by 2 per stat lvl increase.
    // Vig increases health by 15 per lvl.
    protected int Vig { get; set; }
    protected double Health { get; set; }

    // Endurance
    // Determines Stamina
    protected int End { get; set; }
    protected double Stamina { get; set; } // is calculated by End

    // Calculates Strenght
    protected int Str { get; set; } // Strength
    protected int Strenght { get; set; } // Is determined by the Str stat plus any passive or active skills

    // The maximum possible Physical damage.
    // Calculated by strenght and charcter lvl and totalLvl
    protected double MaxPhysDamage { get; set; }

    // The flat damage reducitons. Based on End, Str, Equipment and skills #TODO: implement this and reduction by percentage
    protected double FlatReduc { get; set; }

    protected double
        CalcHealthWithLvls(int vig, int end, int characterLvl, int totalLvl) //#TODO Probably do not need params.
    {
        double health = vig * 15;
        health += characterLvl * 10;
        health += totalLvl * 2;
        health += end;
        return health;
    }
    /*protected void CalcHealthWithLvls()
    {
        int vigHealth = Vig * 15;
        int characterLvlHealth = CharacterLvl * 10;
        int totalLvlHealth = TotalLvl;
        int endHealth = End;
        Health = vigHealth + characterLvlHealth + totalLvlHealth + endHealth;
    }*/

    protected double CalcMaxPhysDamage(int strenght, int charLvl, int totLvl)
    {
        double maxDamage = strenght + charLvl + totLvl;
        return maxDamage;
    }

    protected int CalcStrenght(int str, string characterType) // Check if it is a boss
    {
        if (CharacterType != "Hero")
        {
            if (CharacterType == "Boss")
            {
                Random rnd = new Random();
                int strenght = rnd.Next(0, str + 1); // and any equipment or skills;
                return strenght;
            }

            return str;
        }

        return str;
    }

    protected double CalcStamina(int end, int totLvl)
    {
        return (end * 4) + totLvl;
    }

    protected void CalcTotalLvl()
    {
        TotalLvl = CharacterLvl + Vig + End;
    }

    protected double RestoreStamina(double currentStamina)
    {
        double originalStamina = CalcStamina(End, TotalLvl);
        if (currentStamina < originalStamina)
        {
            currentStamina += 10;
            if (currentStamina >= originalStamina)
            {
                return originalStamina;
            }

            return currentStamina;
        }

        return currentStamina;
    }

    public void Fight(GameCharacter opponent)
    {
        if (Health > 0 && opponent.Health > 0 && Stamina > 0)
        {
            double opponentHealth =
                opponent.CalcHealthWithLvls(opponent.Vig, opponent.End, opponent.CharacterLvl, opponent.TotalLvl);
            double damage = CalcDamageDealt();
            Console.WriteLine(damage);
            opponentHealth -= damage;
            Stamina -= 10;
            if (opponentHealth <= 0 || Health <= 0)
            {
                string name = opponentHealth <= 0 || Health <= 0 ? opponent.Name : Name;
                Console.WriteLine($"{name} has been defeated!", name);
                Console.ReadKey(true);
            }

            if (CharacterType == "Hero")
            {
                Console.WriteLine($"{opponent.Name} took {damage} damage, and now has {opponentHealth} health left");
            }
            else
            {
                Console.WriteLine($"{Name} took {damage} damage, and has now {opponentHealth} health left");
            }
        }

        if (Stamina == 0)
        {
            Stamina = RestoreStamina(Stamina);
            Console.WriteLine($"Stamina is now: {Stamina}");
        }
    }

    protected double CalcDamageDealt()
    {
        if (CharacterType != "Hero")
        {
            int strenght = CalcStrenght(Str, CharacterType);
            return CalcMaxPhysDamage(strenght, CharacterLvl, TotalLvl);
        }

        return MaxPhysDamage;
    }

    protected GameCharacter()
    {
        // #TODO Make them into pure functions.
        // StandardValues
        Name = "Empty_Came_Character";
        CharacterType = "Empty";
        CharacterLvl = 1;
        Vig = 10;
        End = 5;
        Str = 5;
        CalcTotalLvl();
        Health = CalcHealthWithLvls(Vig, End, CharacterLvl, TotalLvl);
        Stamina = CalcStamina(End, TotalLvl);
        Strenght = CalcStrenght(Str, CharacterType);
        MaxPhysDamage = CalcMaxPhysDamage(Str,CharacterLvl, TotalLvl);
    }
}