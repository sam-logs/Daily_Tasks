using EmployeeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Repositories
{
    interface IEmployeeRepo
    {
        Task<IEnumerable<Employee>> Get();
        Task<Employee> Get(int id);
        Task<Employee> Create(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);

    }
}
