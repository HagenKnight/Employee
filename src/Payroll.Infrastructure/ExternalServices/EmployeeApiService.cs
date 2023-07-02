using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Application.Models;
using Payroll.Domain;
using System.Collections.Generic;
using System.IO;

namespace Payroll.Infrastructure.ExternalServices
{
    public class EmployeeApiService : IEmployeeService<EmployeeDTO>
    {
        internal readonly IMapper _mapper;
        protected IMapper Mapper => _mapper;

        public ExternalAPISettings _settings { get; }
        public ILogger<EmployeeApiService> _logger { get; }

        public EmployeeApiService(IOptions<ExternalAPISettings> settings, ILogger<EmployeeApiService> logger, IMapper mapper)
        {
            _settings = settings.Value;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync()
        {
            ApiResp<IEnumerable<EmployeeDTO>> result = new ApiResp<IEnumerable<EmployeeDTO>>();

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync( $"http://dummy.restapiexample.com/api/v1/employees");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResp<IEnumerable<EmployeeDTO>>>(data);
                return result.Data;
            }
            else
            {
                _logger.LogError($"EmployeeApiService - GetAllEmployeesAsync - Error: {response.ReasonPhrase}");
                throw new Exception($"EmployeeApiService - GetAllEmployeesAsync - Error: {response.ReasonPhrase}");
            }
         
        }

        public async Task<EmployeeDTO> GetEmployeeByIdAsync(int id)
        {
            ApiResp<EmployeeDTO> result = new ApiResp<EmployeeDTO>();
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync($"http://dummy.restapiexample.com/api/v1/employee/{id}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResp<EmployeeDTO>>(data);
                return result.Data;
            }
            else
            {
                _logger.LogError($"EmployeeApiService - GetEmployeeByIdAsync - Error: {response.ReasonPhrase}");
                throw new Exception($"EmployeeApiService - GetEmployeeByIdAsync - Error: {response.ReasonPhrase}");
            }
        }
    }
}
