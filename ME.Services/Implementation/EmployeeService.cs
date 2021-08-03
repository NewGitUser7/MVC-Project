using ME.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ME.Services.Implementation
{
    public partial class MEService
    {
        public void InsertEmployee(Employee employeeDM)
        {
            try
            {
                _meunitofwork.MERepository.InsertEmployee(employeeDM);
            }
            catch(Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                return _meunitofwork.MERepository.GetEmployees();
            }
            catch(Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
        public Employee GetEmployee(int Id)
        {
            try
            {
                return _meunitofwork.MERepository.GetEmployee(Id);
            }
            catch(Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
        public void UpdateEmployee(Employee employeeDM)
        {
            try
            {
                _meunitofwork.MERepository.UpdateEmployee(employeeDM);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
        public void DeleteEmployee(int Id)
        {
            try
            {
                _meunitofwork.MERepository.DeleteEmployee(Id);
            }
            catch(Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }
    }
}
