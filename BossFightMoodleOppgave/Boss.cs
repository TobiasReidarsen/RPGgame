namespace BossFightMoodleOppgave;

public class Boss : Enemy   
{
    public Boss()
    {
        CharacterType = "Boss";
        Name = "EvilMANNNNNNNNNNNNN";
        CharacterLvl = 10;
        Vig = 40;
        End = 7;
        Str = 20;
        CalcTotalLvl();
        Health = CalcHealthWithLvls(Vig, End, CharacterLvl, TotalLvl);
        Stamina = CalcStamina(End, TotalLvl); 
        Strenght = CalcStrenght(Str, CharacterType);
    }
    
}