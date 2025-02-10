using EF_Task2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.PLL.Services.Abstruction
{
    public interface IGetEmployee
    {
        public  List<Employee> GetEmployees();
    }
}
