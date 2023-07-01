using Payroll.Domain.Common;

namespace Payroll.Application.Contracts.Infrastructure
{
    public interface IEmployeeService<T> where T : BaseDomainModel
    {
        Task<IReadOnlyList<T>> GetAllEmployeesAsync();
        Task<T> GetEmployeeByIdAsync(int id);
    }
}
