using AutoMapper;
using MediatR;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Domain;

namespace Payroll.Application.Features.Employee.Queries
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeService<EmployeeDTO> _employeeService;

        public GetAllEmployeesHandler(IMapper mapper, IEmployeeService<EmployeeDTO> employeeService)
        {
            _mapper = mapper;
            _employeeService = employeeService;
        }

        public async Task<IEnumerable<EmployeeViewModel>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var listOfEmployees = await _employeeService.GetAllEmployeesAsync();
            IEnumerable<EmployeeViewModel> listOfEmployeesWithSalary = _mapper.Map<IEnumerable<EmployeeViewModel>>(listOfEmployees);

            listOfEmployeesWithSalary = listOfEmployeesWithSalary.Select(employee =>
            {
                employee.AnualSalary = _employeeService.GetEmployeeAnualSalary(employee.Salary);
                return employee;
            });

            return listOfEmployeesWithSalary;
        }
    }
}
