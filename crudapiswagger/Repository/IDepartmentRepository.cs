 
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using crudapiswagger.Models;

namespace crudapiswagger.Repository
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartment();
        Task<Department> GetDepartmentByID(int ID);
        Task<Department> InsertDepartment(Department objDepartment);
        Task<Department> UpdateDepartment(Department objDepartment);
        bool DeleteDepartment(int ID);
    }
}