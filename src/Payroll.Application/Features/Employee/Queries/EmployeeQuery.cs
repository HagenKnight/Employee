using MediatR;
using Payroll.Domain;

namespace Payroll.Application.Features.Employee.Queries
{
    public class GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeViewModel>> { }

    public class GetEmployeeQuery : IRequest<EmployeeViewModel>
    {
        public int Id { get; set; }
        public GetEmployeeQuery(int id) => Id = id;
    }
}
