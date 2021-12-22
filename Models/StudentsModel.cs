using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class StudentsModel:ResponseModel
    {
        public string StudentID { get; set; } = "";
        public string StudentName { get; set; } = "";
        public string Contact { get; set; } = "";
        public string ClassID { get; set; } = "";
        public string Gender { get; set; } = "";


    }
}
