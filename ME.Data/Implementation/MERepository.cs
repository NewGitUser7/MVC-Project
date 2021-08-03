using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME.Data.Contracts;
using ME.Data.Model;
using ME.Data.Edmx;
using System.Data.Entity;

namespace ME.Data.Implementation
{
    public class MERepository : IMERepository
    {
        #region Constructor
        private MEEntities _entities;
        public MERepository(MEEntities entities)
        {
            _entities = entities;
        }
        #endregion

        #region Employee

        /// <summary>
        /// To get employees from EmployeeView
        /// </summary>
        /// <param name=""></param>
        /// <returns>Employees</returns>
        public List<Employee> GetEmployees()
        {
            var query = _entities.EmployeeViews.AsNoTracking().ToList();
            var results = new List<Employee>();
           
               foreach(var result in query)
                {
                    results.Add(new Employee
                    {
                        EmployeeID = result.EmployeeID,
                        FirstName = result.FirstName,
                        LastName = result.LastName,
                        Created = result.Created,
                        Modified = result.Modified
                    });
                }
            
            results = results.ToList();
            return results;
        }

        /// <summary>
        /// To get employee from EmployeeView
        /// </summary>
        /// <param name="Id">EmployeeId</param>
        /// <returns>Employee object</returns>
        public Employee GetEmployee(int Id)
        {
            var query = _entities.EmployeeViews.Where(s => s.EmployeeID == Id).FirstOrDefault();
            var result = new Employee();
            result.EmployeeID = query.EmployeeID;
            result.FirstName = query.FirstName;
            result.LastName = query.LastName;
            result.Created = query.Created;
            result.Modified = query.Modified;
            return result;
        }

        /// <summary>
        /// To Insert employee into EmployeeTable
        /// </summary>
        /// <param name="employee">employee object</param>
        /// <returns>Void</returns>
        public void InsertEmployee(Employee employee)
        {
                _entities.Employees.Add(employee);
                _entities.Save();
        }

        /// <summary>
        /// To update employee on EmployeeTable
        /// </summary>
        /// <param name="employee">employee object</param>
        /// <returns>Void</returns>
        public void UpdateEmployee(Employee employee)
        {
            _entities.Entry(employee).State = EntityState.Modified;
            _entities.Save();
        
        }
        ///<summary>
        ///To delete employee from EmployeeTable
        ///</summary>
        ///<param name="Id">EmployeeId</param>
        ///<returns>Void</returns>
        public void DeleteEmployee(int Id)
        {
            var employee = _entities.Employees.SingleOrDefault(x => x.EmployeeID == Id);
            _entities.Employees.Remove(employee);
            _entities.Save();
        }
        #endregion

    }
}
