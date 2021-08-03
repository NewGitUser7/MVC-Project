using ME.Data.Model;
using ME.Site.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME.Site.Mappers
{
    public class DataModelToViewModelMapper
    {
        public static void MapDMListToVMList(List<Employee> sources, List<EmployeeViewModel> destinations)
        {
            if(sources!=null)
            {
            
                foreach(var item in sources)
                {
                    var employeeVM = new EmployeeViewModel();
                    MapEmployeeDMToVM(item, employeeVM);
                    destinations.Add(employeeVM);
                }
            }
        }
        public static void MapEmployeeDMToVM(Employee source, EmployeeViewModel destination)
        {
            destination.Id = source.EmployeeID;
            destination.FirstName = source.FirstName;
            destination.LastName = source.LastName;
            destination.Created = source.Created;
            destination.Modified = source.Modified;

        }
    }
}