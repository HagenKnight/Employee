using MediatR;
using Payroll.Domain;

namespace Payroll.Application.Features.Employee.Queries
{
    public class GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeDTO>> { }

    public class GetEmployeeQuery : IRequest<EmployeeDTO>
    {
        public int Id { get; set; }
        public GetEmployeeQuery(int id) => Id = id;
    }
}
