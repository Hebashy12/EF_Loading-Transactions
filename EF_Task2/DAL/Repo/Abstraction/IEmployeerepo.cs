using EF_Task2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.DAL.Repo.Abstraction
{
    public interface IEmployeeRepo
    {
        public List<Employee> GetEmployees();
        public List<Department> GetDepartments();
    }
}
