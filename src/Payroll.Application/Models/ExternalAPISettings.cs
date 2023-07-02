namespace Payroll.Application.Models
{
    public class ExternalAPISettings
    {
        public string BaseUrl { get; set; } = string.Empty;
        public EmployeeEndpoint EmployeeEndpoint { get; set; }
    }


    public class EmployeeEndpoint
    {
        public string GetEmployees { get; set; } = string.Empty;
        public string GetEmployee { get; set; } = string.Empty;
    }
}
