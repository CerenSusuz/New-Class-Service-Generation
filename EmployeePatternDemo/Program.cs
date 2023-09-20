class Program
{
    static void Main(string[] args)
    {
        var fullTimeEmp = EmployeeFactory.CreateEmployee("fulltime");
        fullTimeEmp.Say(); // Output: "I am a full-time employee and my hourly rate is 30"

        var partTimeEmp = EmployeeFactory.CreateEmployee("parttime");
        partTimeEmp.Say(); // Output: "I am a part-time employee and my hourly rate is 15"

        var temporaryEmp = EmployeeFactory.CreateEmployee("temporary");
        temporaryEmp.Say(); // Output: "I am a temporary employee and my hourly rate is 20"

        var contractorEmp = EmployeeFactory.CreateEmployee("contractor");
        contractorEmp.Say(); // Output: "I am a contractor and my hourly rate is 40"

    }
}