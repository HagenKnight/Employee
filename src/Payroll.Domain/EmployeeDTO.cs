using Payroll.Domain.Common;

namespace Payroll.Domain
{
    public class EmployeeDTO  : BaseDTO
    {
        public string employee_name { get; set; } = string.Empty;
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; } = string.Empty;
        public int Id { get; set; }
    }
}
