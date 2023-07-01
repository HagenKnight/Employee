using Payroll.Domain.Common;

namespace Payroll.Domain
{
    public class EmployeeDTO : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
