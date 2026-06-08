namespace InterfaceSegregation;

public class Developer : IActivitiesWorker, IActivitiesDeveloper
{
    public Developer() {}

    public void Comunicate()
    {
        Console.WriteLine("I'm talking to the team user");
    }

    public void Design()
    {
        Console.WriteLine("I'm designing new futures");
    }

    public void Develop()
    {
        Console.WriteLine("I'm developing the functionalities required");
    }
}