public class Contractor : Employee
{
    public override decimal HourlyRate => 40;
    public override void Say()
    {
        Console.WriteLine($"I am a contractor and my hourly rate is {HourlyRate}");
    }
}