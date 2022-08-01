using EmployeeAPI.Models;
using EmployeeAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepo _employeeContent;
        public EmployeesController(EmployeeContent employeeContent)
        {
            _employeeContent = (IEmployeeRepo)employeeContent;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeContent.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>>GetEmployees(int id)
        {
            return await _employeeContent.Get(id);
        }
    }
}
