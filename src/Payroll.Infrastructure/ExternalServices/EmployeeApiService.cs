using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Application.Models;
using Payroll.Domain;
using Payroll.Domain.Exceptions;
using Payroll.Domain.Exceptions.Api;
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
            HttpClient client = new HttpClient();
            ApiResp<IEnumerable<EmployeeDTO>>? result = new ApiResp<IEnumerable<EmployeeDTO>>();

            HttpResponseMessage response = await client.GetAsync($"http://dummy.restapiexample.com/api/v1/employees");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResp<IEnumerable<EmployeeDTO>>>(data);
                if (result != null && result.Data != null)
                    return result.Data;
                else
                {
                    _logger.LogError("The Employee list is empty!");
                    throw new EntityNotFoundException("The Employee list is empty!");
                }
            }
            else
            {
                _logger.LogError($"{response.StatusCode} - {response.ReasonPhrase}");
                throw new ExternalApiException($"StatusCode: {(int)response.StatusCode} - {response.ReasonPhrase}");
            }

        }

        public async Task<EmployeeDTO> GetEmployeeByIdAsync(int id)
        {
            HttpClient client = new HttpClient();
            ApiResp<EmployeeDTO>? result = new ApiResp<EmployeeDTO>();

            HttpResponseMessage response = await client.GetAsync($"http://dummy.restapiexample.com/api/v1/employee/{id}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ApiResp<EmployeeDTO>>(data);
                if (result != null && result.Data != null)
                    return result.Data;
                else
                {
                    _logger.LogError($"The record for Employee Id {id} was not found!");
                    throw new EntityNotFoundException($"The record for Employee Id {id} was not found!");
                }
            }
            else
            {
                _logger.LogError($"{response.StatusCode} - {response.ReasonPhrase}");
                throw new ExternalApiException($"StatusCode: {(int) response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
