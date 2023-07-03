using Payroll.Domain.Common;

namespace Payroll.Application.Contracts.Infrastructure
{
    public interface IEmployeeService<T> where T : BaseDTO
    {
        Task<IEnumerable<T>> GetAllEmployeesAsync();
        Task<T> GetEmployeeByIdAsync(int id);
        int GetEmployeeAnualSalary(int employeeSalary);
    }
}
