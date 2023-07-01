using AutoMapper;
using MediatR;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Domain;

namespace Payroll.Application.Features.Employee.Queries
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeService<EmployeeDTO> _employeeService;

        public GetAllEmployeesHandler(IMapper mapper, IEmployeeService<EmployeeDTO> employeeService)
        {
            _mapper = mapper;
            _employeeService = employeeService;
        }

        public async Task<IEnumerable<EmployeeDTO>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken) =>
            await _employeeService.GetAllEmployeesAsync();
    }
}
