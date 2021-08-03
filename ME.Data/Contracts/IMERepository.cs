using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Data.Model;

namespace ME.Data.Contracts
{
    public interface IMERepository
    {
        #region Employee
        void InsertEmployee(Employee employeeDm);
        List<Employee> GetEmployees();
        Employee GetEmployee(int Id);
        void UpdateEmployee(Employee employeeDM);
        void DeleteEmployee(int Id);
        #endregion
    }
}
