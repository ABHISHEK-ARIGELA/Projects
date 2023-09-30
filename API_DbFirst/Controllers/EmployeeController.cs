using API_DbFirst.EFModels;
using API_DbFirst.EFPersistanceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DbFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("CreateEmployee")]
        [HttpPost]
        public IActionResult Create(Employee e)
        {
            bool IsSucess = EmployeeContext.CreateEmployee(e);
            return RedirectToAction("List");
        }
        [Route("ListOfEmployees")]
        [HttpGet]
        public IActionResult List()
        {
            List<Employee> l = EmployeeContext.GetEmployees();
            return Ok(l);
        }
        [Route("GetEmployeeById")]
        [HttpGet]
        public IActionResult Detail(int id)
        {
            Employee e = EmployeeContext.getEmployeeById(id);
            if (e != null)
            { return Ok(e); }
            return BadRequest("That record is not present");
        }
        [Route("EditEmployee")]
        [HttpPost]
        public IActionResult Edit(Employee e)
        {
            bool IsSucess = EmployeeContext.UpdateEmployee(e);
            if (IsSucess)
            { return RedirectToAction("List"); }
            return BadRequest("first of all That record is not present to edit ");
        }
        [Route("DeleteEmployee")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            bool IsSucess = EmployeeContext.DeleteEmployee(id);
            if (IsSucess)
            { return Ok("SuccesfullyDeleted"); }
            return BadRequest("first of all That record is not present to delete ");
        }

    }
}
