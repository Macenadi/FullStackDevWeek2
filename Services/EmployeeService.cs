using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackDevWeek2.Models;

namespace FullStackDevWeek2.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            // temporary stub — return empty list. Replace with real data access.
            //return Task.FromResult<IEnumerable<Employee>>(Enumerable.Empty<Employee>());

            return await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/employees");

            throw new NotImplementedException();

        }
    }
}
