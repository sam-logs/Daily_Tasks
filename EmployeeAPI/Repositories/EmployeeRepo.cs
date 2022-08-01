using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContent _content;

        public EmployeeRepo(EmployeeContent content)
        {
            _content = content;
        }
        public async Task<Employee> Create(Employee employee)
        {
            _content.Employees.Add(employee);
            await _content.SaveChangesAsync();
            return employee;
        }

        public async Task Delete(int id)
        {
            var employeeToDelete = await _content.Employees.FindAsync(id);
            _content.Employees.Remove(employeeToDelete);
            await _content.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            return await _content.Employees.ToListAsync();
        }

        public  async Task<Employee> Get(int id)
        {
            return await _content.Employees.FindAsync(id);
        }

        public async Task Update(Employee employee)
        {
            _content.Entry(employee).State = EntityState.Modified;
            await _content.SaveChangesAsync();
        }
    }
}
