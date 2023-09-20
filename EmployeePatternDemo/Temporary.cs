public class Temporary : Employee
{
    public override decimal HourlyRate => 20;
    public override void Say()
    {
        Console.WriteLine($"I am a temporary employee and my hourly rate is {HourlyRate}");
    }
}