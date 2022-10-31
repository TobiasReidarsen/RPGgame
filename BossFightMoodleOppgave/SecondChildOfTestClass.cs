namespace BossFightMoodleOppgave;

public class SecondChildOfTestClass : TestClass
{
    public override string Tekst()
    {
        return "SecondChild.Sum() Kjører" + y;
    }

    public override int IntGerFunc()
    {
        return 0000;
    }

    public SecondChildOfTestClass(string _y)
    {
        y = _y;
        Console.WriteLine(y);
    }
    
}

