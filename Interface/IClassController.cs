using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.Interface
{
    internal interface IClassController
    {

        Task<ClassModel> AddClass(ClassModel model);
        Task<DataTable> GetClasses();
        Task<DataTable> GetClassByID(ClassModel model);
        Task<DataTable> GetClassByTitle(ClassModel model);

        ClassModel UpdateClassTitle(ClassModel model);
        ClassModel RemoveClass(ClassModel model);
    }
}
