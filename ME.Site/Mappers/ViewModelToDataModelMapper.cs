using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ME.Site.ViewModels;
using ME.Data.Model;

namespace ME.Site.Mappers
{
    public class ViewModelToDataModelMapper
    {
        public static void MapEmployeeVMToDM(EmployeeViewModel source, Employee destination)
        {
            destination.EmployeeID = source.Id;
            destination.FirstName = source.FirstName;
            destination.LastName = source.LastName;
            destination.Created = source.Created;
            destination.Modified = source.Modified;
           
        }
    }
}