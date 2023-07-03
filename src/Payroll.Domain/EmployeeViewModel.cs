using Payroll.Domain.Common;

namespace Payroll.Domain
{
    public class EmployeeViewModel : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Salary { get; set; }
        public int AnualSalary { get; set; }
        public string ProfileImage { get; set; } = string.Empty;
    }
}
