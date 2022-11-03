namespace BossFightMoodleOppgave;

public class Hero : GameCharacter
{
   public Hero()
   {
      Name = "Tobias";
      CharacterType = "Hero";
      CharacterLvl = 10;
      Vig = 20;
      End = 4;
      Str = 10;
      CalcTotalLvl();
      Health = CalcHealthWithLvls(Vig, End, CharacterLvl, TotalLvl);
      Stamina = CalcStamina(End, TotalLvl); 
      Strenght = CalcStrenght(Str, CharacterType);

   }
}