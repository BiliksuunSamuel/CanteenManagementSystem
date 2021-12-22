using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.Interface
{
    internal interface IStudentsController
    {
        Task<DataTable> GetStudents();
        Task<DataTable> FilterStudentsByClass(ClassModel model);
        StudentsModel RegisterStudent(StudentsModel model);
        StudentsModel DeleteStudent(StudentsModel model);
        StudentsModel UpdateStudentInfo(StudentsModel model);
        DataTable GetStudentByPhone(StudentsModel model);
        DataTable GetStudentByID(StudentsModel student);
        DataTable GetStudentByName(StudentsModel student);
        Task<DataTable> GetStudentsByClass(StudentsModel model);
        Task<DataTable> GetStudentsByGender(StudentsModel model);
        StudentsModel UpdateStudentClass(StudentsModel model);

        DataTable SearchStudent(string filter);
        Task<DataTable> GetRegisteredStudents();
    }
}
