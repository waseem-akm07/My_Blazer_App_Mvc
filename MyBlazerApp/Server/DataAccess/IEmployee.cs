using MyBlazerApp.Server.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazerApp.Server.DataAccess
{
    public interface IEmployee
    {
        IEnumerable<Tbemployee> GetAllEmployees();
        Tbemployee GetEmployee(int id);
        void DeleteEmployee(int id);
        void AddEmployee(Tbemployee employee);
        void UpdateEmployee(Tbemployee employee);

    }
}
