using ME.Services.Contracts;
using ME.Services.Factories;
using ME.Site.ViewModels;
using ME.Data.Model;
using ME.Site.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace ME.Site.Models
{
    public class EmployeeModel : IEmployeeModel
    {

        #region Constructor
        public EmployeeModel(ILog log, IServiceFactory serviceFactory)
        {
            Log = log;
            _serviceFactory = serviceFactory;
            
        }
        #endregion

        private IServiceFactory _serviceFactory;
        private IMEService _service;
        public IMEService Service
        {
            get
            {
                return (_service != null) ? _service : _service = _serviceFactory.Create();
            }
        }
        public log4net.ILog Log { get; set; }


        public List<EmployeeViewModel> GetEmployees()
        {
            List<EmployeeViewModel> employeeVMList = new List<EmployeeViewModel>();
            try
            {
                List<Employee> employeeDMList = Service.GetEmployees().OrderByDescending(e =>e.EmployeeID).ToList();
                DataModelToViewModelMapper.MapDMListToVMList(employeeDMList, employeeVMList);
            }
            catch(Exception ex)
            {
                Log.Error(ex);
            }
            finally
            {
                Service.Dispose();
            }

            return employeeVMList;

        }

        public void InsertEmployee(EmployeeViewModel employeeVM)
        {
            
            try
            {
                Employee employeeDM = new Employee();
                employeeVM.Created = DateTime.Now;
                employeeVM.Modified = DateTime.Now;
                ViewModelToDataModelMapper.MapEmployeeVMToDM(employeeVM, employeeDM);
                Service.InsertEmployee(employeeDM);
            }
            catch(Exception)
            {

            }
            finally
            {
                Service.Dispose();
            }
            
        }
        public EmployeeViewModel GetEmployee(int Id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            try
            {
                var employeeDM = Service.GetEmployee(Id);
                DataModelToViewModelMapper.MapEmployeeDMToVM(employeeDM, employeeVM);
                
            }
            catch(Exception)
            {

            }
            finally
            {
                Service.Dispose();
            }
            return employeeVM;
        }
        public void UpdateEmployee(EmployeeViewModel employeeVM)

        {
            try
            {
                Employee employeeDM = new Employee();
                employeeVM.Modified = DateTime.Now;
                ViewModelToDataModelMapper.MapEmployeeVMToDM(employeeVM, employeeDM);
                Service.UpdateEmployee(employeeDM);
            }
            catch (Exception)
            {

            }
            finally
            {
                Service.Dispose();
            }
        }
        public void DeleteEmployee(int Id)
        {
            try
            {
                Service.DeleteEmployee(Id);
            }
            catch(Exception)
            {

            }
            finally
            {
                Service.Dispose();
            }
        }
    }
}