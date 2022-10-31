using BossFightMoodleOppgave;

Hero hero = new Hero("Tobias", "Stor", 101, 500, 200, 50);
Enemy bossMan = new Enemy("BossMann", "BITTE LITEN!", 10000, 5000, 3245, 200);


void TestAbstract()
{
    ChildOfTestClass firstCh = new ChildOfTestClass("232323");
    SecondChildOfTestClass secondCh = new SecondChildOfTestClass(" SecondChild _y");
    Console.WriteLine(firstCh.Tekst());
    Console.WriteLine(firstCh.TekstTekst(" FirstCh"));

    Console.ReadKey(true);
    Console.WriteLine();

    Console.WriteLine(secondCh.Tekst());
    Console.WriteLine(secondCh.TekstTekst(" SecondCh"));
    Console.WriteLine(secondCh.IntGerFunc());
    //Console.WriteLine(secondCh.IntGerFunc(3425));
}