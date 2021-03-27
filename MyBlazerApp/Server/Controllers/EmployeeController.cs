using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlazerApp.Server.DataAccess;
using MyBlazerApp.Server.Models;

namespace MyBlazerApp.Server.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployee _emp;
        public EmployeeController(IEmployee emp)
        {
            _emp = emp;
        }

        [HttpGet]
        [Route("/api/Employee/Index")]
        public IEnumerable<Tbemployee> Index()
        {
            return _emp.GetAllEmployees();
        }

        [HttpGet]
        [Route("/api/Employee/Details/{id}")]
        public Tbemployee Details(int id)
        {
            return _emp.GetEmployee(id);
        }

        [HttpPost]
        [Route("/api/Employee/Create")]
        public void Create([FromBody] Tbemployee emp)
        {
           _emp.AddEmployee(emp);
        }
                
        [HttpPut]
        [Route("/api/Employee/Edit")]
        public void Put([FromBody] Tbemployee emp)
        {
            _emp.UpdateEmployee(emp);
        }

        [HttpDelete]
        [Route("/api/Employee/Delete/{id}")]
        public void Delete(int id)
        {
            _emp.DeleteEmployee(id);
        }
    }
}
