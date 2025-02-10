using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.DAL.Entities
{
    [ComplexType]
    public class Adress
    {
        public string Country { get;private set; }
        public string City { get;private set; }
        public string Address { get;private set; }
    }
}
