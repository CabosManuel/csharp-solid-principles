namespace InterfaceSegregation;

public class ScrumMaster : IActivitiesWorker, IActivitiesScrumMaster
{
    public ScrumMaster() {}

    public void Comunicate()
    {
        Console.WriteLine("I'm talking to the team user");
    }

    public void Plan()
    {
        Console.WriteLine("I'm planning user stories");
    }
}