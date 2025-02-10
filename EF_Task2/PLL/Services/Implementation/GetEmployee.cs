using EF_Task2.DAL.Entities;
using EF_Task2.DAL.Repo.Abstraction;
using EF_Task2.DAL.Repo.Implementation;
using EF_Task2.PLL.Services.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.PLL.Services.Implementation
{
    public class GetEmployee : IGetEmployee,IGetDepartment
    {
        IEmployeeRepo _empr = new EmployeeRepo();
        public List<Employee> GetEmployees()
        {
            var employees = _empr.GetEmployees();
            return employees;

        }
       

        public List<Department> GetDepartments()
        {
            var employees = _empr.GetDepartments();
            return employees;
        }
    }
}
