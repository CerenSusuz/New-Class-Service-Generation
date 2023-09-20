public class PartTime : Employee
{
    public override decimal HourlyRate => 15.0M;
    public override void Say()
    {
        Console.WriteLine("I'm a Part-time employee with hourly rate of " + HourlyRate);
    }
}