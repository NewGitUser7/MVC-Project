using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ME.Site.ViewModels;
using ME.Site.Models;

namespace ME.Site.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeModel Model;
        public EmployeeController(IEmployeeModel model)
        {
            Model = model;
        }

        public ActionResult GetEmployees()
        {
            EmployeeDataViewModel employeeDVM = new EmployeeDataViewModel();
            employeeDVM.employeeList = Model.GetEmployees();
            return View("EmployeeDetails", employeeDVM);
        }
        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                Model.InsertEmployee(employeeVM);
            }
            return RedirectToAction("GetEmployees");
        }

  
        public ActionResult EditEmployee(int Id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM = Model.GetEmployee(Id);
            return View(employeeVM);
        }

        [HttpPost]
        public ActionResult SaveEmployee(EmployeeViewModel employeeVM)
        {
            Model.UpdateEmployee(employeeVM);
            return RedirectToAction("GetEmployees");
        }

        public ActionResult DeleteEmployee(int Id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM = Model.GetEmployee(Id);
            return View(employeeVM);
        }
        [HttpPost]
        public ActionResult DeleteEmployee(EmployeeViewModel employeeVM)
        {
            Model.DeleteEmployee(employeeVM.Id);
            return RedirectToAction("GetEmployees");
        }
    }
}