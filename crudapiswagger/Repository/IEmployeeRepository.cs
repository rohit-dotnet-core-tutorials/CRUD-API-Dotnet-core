


using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using crudapiswagger.Models;
namespace crudapiswagger.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeByID(int ID);
        Task<Employee> InsertEmployee(Employee objEmployee);
        Task<Employee> UpdateEmployee(Employee objEmployee);
        bool DeleteEmployee(int ID);
    }
}