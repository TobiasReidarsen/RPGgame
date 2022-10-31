namespace BossFightMoodleOppgave;

public class ChildOfTestClass : TestClass
{
    public override string Tekst()
    {
        return "ChildOfTestClass.Tekst() Kjører";
    }

    public override string TekstTekst(string i)
    {
        return "ChildOfTestClass.TekstTeskt() Kjører" + y;
    }

    public ChildOfTestClass(string _y)
    {
        y = _y;
        Console.WriteLine(y);
    }
}