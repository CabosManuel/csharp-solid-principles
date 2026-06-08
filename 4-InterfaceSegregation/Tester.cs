namespace InterfaceSegregation;

public class Tester : IActivitiesWorker, IActivitiesTester
{
    public Tester() {}

    public void Comunicate()
    {
        Console.WriteLine("I'm talking to the team user");
    }

    public void Test()
    {
        Console.WriteLine("I'm testing the application");
    }
}