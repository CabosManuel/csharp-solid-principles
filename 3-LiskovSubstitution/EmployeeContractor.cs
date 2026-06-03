namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(
            string fullname,
            int hoursWorked,
            int hourValue = 40
        ) :base(fullname, hoursWorked) {}
    }
}