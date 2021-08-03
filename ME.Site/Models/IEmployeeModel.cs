using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Site.ViewModels;

namespace ME.Site.Models
{
    public interface IEmployeeModel
    {
        void InsertEmployee(EmployeeViewModel employeeVM);
        List<EmployeeViewModel> GetEmployees();
        EmployeeViewModel GetEmployee(int Id);
        void UpdateEmployee(EmployeeViewModel employeeVM);
        void DeleteEmployee(int Id);
    }
}
