namespace OpenClose;

public abstract class Employee(string fullname, int hoursWorked)
{
    public string Fullname { get; set; } = fullname;
    public int HoursWorked { get; set; } = hoursWorked;
}