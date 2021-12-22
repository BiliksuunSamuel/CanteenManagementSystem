using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class ClassModel:ResponseModel
    {
        public string ClassID { get; set; } = "";
        public string ClassTitle { get; set; } = "";
    }
}
