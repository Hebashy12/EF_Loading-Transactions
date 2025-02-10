using EF_Task2.PLL.Services.Implementation;

namespace EF_Task2.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new GetEmployee();
            var employees=emp.GetEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Departments?.Name);
            }


            Console.WriteLine("***************");

            var Dept = new GetEmployee();
            var Department = Dept.GetDepartments();
            foreach (var Dep in Department)
            {
                Console.WriteLine(Dep.Employees[0]);
            }
        }
    }
}
