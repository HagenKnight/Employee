namespace Payroll.Domain
{
    public class Root
    {
        public string Status { get; set; } = string.Empty;
        public EmployeeDTO Data { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
