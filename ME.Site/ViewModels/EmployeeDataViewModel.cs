using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME.Site.ViewModels
{
    public class EmployeeDataViewModel
    {
        public EmployeeDataViewModel()
        {
            employeeList = new List<EmployeeViewModel>();
        }
        public List<EmployeeViewModel> employeeList { get; set; }
        public EmployeeViewModel employee { get; set; }
    }
}