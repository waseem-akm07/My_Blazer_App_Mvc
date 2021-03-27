using MyBlazerApp.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;

namespace MyBlazerApp.Server.DataAccess
{
    public class EmployeeRepo: IEmployee
    {
        private MvcdbContext _context;
        public EmployeeRepo(MvcdbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Tbemployee employee)
        {
            _context.Tbemployee.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Tbemployee emp = _context.Tbemployee.Find(id);
            _context.Tbemployee.Remove(emp);
            _context.SaveChanges();
        }

        public IEnumerable<Tbemployee> GetAllEmployees()
        {
            return _context.Tbemployee.ToList();
        }

        public Tbemployee GetEmployee(int id)
        {
            Tbemployee emp = _context.Tbemployee.Find(id);
            return emp;
        }

        public void UpdateEmployee(Tbemployee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
