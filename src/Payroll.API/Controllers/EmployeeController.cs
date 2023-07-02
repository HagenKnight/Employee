using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payroll.Application.Features.Employee.Queries;
using Payroll.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payroll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<EmployeeViewModel>> GetEmployees() =>
            await _mediator.Send(new GetAllEmployeesQuery());


        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<EmployeeViewModel> GetEmploye(int id) =>
            await _mediator.Send(new GetEmployeeQuery(id));


    }
}
