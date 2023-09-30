using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.EFPersistanceLayer;
using MVC_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Controllers
{
    public class AbhishekController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Abhishek e)
        {
            bool isSuccess = AbhishekContext.CreateEmployee(e);
            if (isSuccess)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            List<Abhishek> l = AbhishekContext.getEmployees();
            return View(l);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Abhishek e = AbhishekContext.getEmployeeById(id);
            return View(e);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Abhishek e = AbhishekContext.getEmployeeById(id);
            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Abhishek e)
        {
            AbhishekContext.UpdateEmployee(e);
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Abhishek e = AbhishekContext.getEmployeeById(id);
            return View(e);
        }
        [HttpPost]
        public IActionResult Delete(Abhishek e)
        {
            AbhishekContext.DeleteEmployee(e.Id);
            return RedirectToAction("List");
        }
    }
}
