using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Data.Model;

namespace ME.Services.Contracts
{
    public interface IEmployeeService
    {
        void InsertEmployee(Employee employeeDM);
        List<Employee> GetEmployees();
        Employee GetEmployee(int Id);
        void UpdateEmployee(Employee employeeDM);
        void DeleteEmployee(int Id);


    }
}
