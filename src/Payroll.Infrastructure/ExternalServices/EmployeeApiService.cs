using Payroll.Application.Contracts.Infrastructure;
using Payroll.Domain;

namespace Payroll.Infrastructure.ExternalServices
{
    public class EmployeeApiService : IEmployeeService<EmployeeDTO>
    {
        public async Task<IReadOnlyList<EmployeeDTO>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDTO> GetEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
