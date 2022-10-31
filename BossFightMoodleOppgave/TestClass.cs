namespace BossFightMoodleOppgave;

public abstract class TestClass
{
    protected string y { get; set; }
    public abstract string Tekst();

    public virtual string TekstTekst(string b)
    {
        string a = Tekst();
        return a + b + y;
    }

    public virtual int IntGerFunc()
    {
        return 9999;
    }
}