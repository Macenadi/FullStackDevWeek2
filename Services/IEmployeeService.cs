using FullStackDevWeek2.Components.Pages;
using FullStackDevWeek2.Models;

namespace FullStackDevWeek2.Services
{
    public interface IEmployeeService
    {
       Task<IEnumerable<Employee>> GetEmployees();
    }
}
