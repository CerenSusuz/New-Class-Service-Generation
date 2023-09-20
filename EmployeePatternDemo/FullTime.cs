public class FullTime : Employee
{
    public override decimal HourlyRate => 30.0M;
    public override void Say()
    {
        Console.WriteLine("I'm a Full-time employee with hourly rate of " + HourlyRate);
    }
}