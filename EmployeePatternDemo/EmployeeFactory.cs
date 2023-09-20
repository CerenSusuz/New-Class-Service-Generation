public class EmployeeFactory
{
    public static Employee CreateEmployee(string employeeType)
    {
        switch (employeeType.ToLower())
        {
            case "fulltime":
                return new FullTime();
            case "parttime":
                return new PartTime();
            case "temporary":
                return new Temporary();
            case "contractor":
                return new Contractor();
            default:
                throw new ArgumentException("Invalid employee type");
        }
    }
}