using AutoMapper;
using MediatR;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Domain;

namespace Payroll.Application.Features.Employee.Queries
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, EmployeeViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeService<EmployeeDTO> _employeeService;

        public GetEmployeeHandler(IMapper mapper, IEmployeeService<EmployeeDTO> employeeService)
        {
            _mapper = mapper;
            _employeeService = employeeService;
        }

        public async Task<EmployeeViewModel> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            var employee = await _employeeService.GetEmployeeByIdAsync(request.Id);

            return _mapper.Map<EmployeeViewModel>(employee);
        }

    }
}
