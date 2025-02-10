using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.DAL.Entities
{
    public class Department
    {
        public Department()
        {
            
        }
        public Department(long id, string name, Adress adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public virtual List<Employee> Employees { get; set; }
        
    }
}
