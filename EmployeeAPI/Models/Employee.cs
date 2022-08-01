using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class Employee
    {
       [Key]
       public Guid Id { get; set; }
       public string UserEmail { get; set; }
       public string Password { get; set; }
       public int RoleId { get; set; }
    }
}
