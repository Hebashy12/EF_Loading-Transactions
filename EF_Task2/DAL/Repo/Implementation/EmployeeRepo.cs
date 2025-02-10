using EF_Task2.DAL.Database;
using EF_Task2.DAL.Entities;
using EF_Task2.DAL.Repo.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.DAL.Repo.Implementation
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        AplicationDBContext dbcon = new AplicationDBContext();
        public List<Employee> GetEmployees()
        {
            //Egar Loading
            #region Eager Loading
            //var employees = dbcon.Employees.Where(e=>e.Id>0).Include(e=>e.Departments).ToList();
            //return employees;
            #endregion
            #region Lazy Loading
            //var employees = dbcon.Employees.Where(e => e.Id > 0).ToList();
            //return employees;
            #endregion


            #region Explicit Loading
            //var employees = dbcon.Employees.Where(e => e.Id > 0).ToList();
            //foreach (var employee in employees)
            //{
            //    dbcon.Entry(employee).Reference(e => e.Departments).Load();
            //}
            //return employees;

            #endregion

            #region Transactions
            //var tr= dbcon.Database.BeginTransaction();
            // try
            // {
            //     var employees1 = dbcon.Employees.Where(e => e.Id > 0).ToList();
            //     var employee = dbcon.Employees.Where(e => e.Id > 0).FirstOrDefault();

            //     dbcon.Entry(employee).Reference(e => e.Departments).Load();
            //     tr.Commit();

            // }
            // catch (Exception ex) 
            // {
            //     tr.Rollback();
                    //throw new Exception("You Have an Issue plz try again");
            // }
            var tr= dbcon.Database.BeginTransaction();
            try
            {
                var employees1 = dbcon.Employees.Where(e => e.Id > 0).ToList();
                var employee = dbcon.Employees.Where(e => e.Id > 0).FirstOrDefault();
                tr.CreateSavepoint("p1");
                dbcon.Entry(employee).Reference(e => e.Departments).Load();
                tr.Commit();



                return employees1;

            }
            catch (Exception ex) 
            {
                tr.RollbackToSavepoint("p1");
                tr.Commit();
                throw new Exception("You Have an Issue plz try again");
            }
            #endregion


        }
        public List<Department> GetDepartments() 
        {
            var employees = dbcon.Department.Where(e => e.Id > 0).ToList();
            foreach (var employee in employees)
            {
                dbcon.Entry(employee).Collection(e => e.Employees).Load();
            }
            return employees;
        }
    }
}
