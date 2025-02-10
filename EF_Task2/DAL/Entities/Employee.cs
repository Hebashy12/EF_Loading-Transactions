using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.DAL.Entities
{
    public class Employee
    {
        public Employee()
        {
            
        }
        public Employee(long id, string name, decimal salary, Adress adress)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Adress = adress;
        }

        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }
        [ForeignKey("Departments")]
        public long DepartmentID { get; private set; }
        public Adress Adress { get; private set; }=new Adress();
        public virtual Department? Departments { get; private set; }
        public override string ToString()
        {
            return $"ID:{Id}:: Name:{Name}:: Salary:{Salary}";
        }
    }
}
